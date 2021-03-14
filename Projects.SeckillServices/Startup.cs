using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Projects.Common.Exceptions.Handlers;
using Projects.Common.Filters;
using Projects.Common.Users;
using Projects.Cores.Register.Extensions;
using Projects.SeckillServices.Context;
using Projects.SeckillServices.Repositories;
using Projects.SeckillServices.Services;

namespace Projects.SeckillServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //1.���dbcontext
            services.AddDbContextPool<SeckillContext>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")).
                    UseLoggerFactory(LoggerFactory.Create(config => config.AddConsole()));
            });

            // 2��ע����Ʒservice
            services.AddScoped<ISeckillService, SeckillServiceImpl>();
            services.AddScoped<ISeckillRecordService, SeckillRecordServiceImpl>();
            services.AddScoped<ISeckillTimeModelService, SeckillTimeModelServiceImpl>();

            // 3��ע����Ʒ�ִ�
            services.AddScoped<ISeckillRepository, SeckillRepository>();
            services.AddScoped<ISeckillRecordRepository, SeckillRecordRepository>();
            services.AddScoped<ISeckillTimeModelRepository, SeckillTimeModelRepository>();

            // 4����ӷ���ע��
            services.AddServiceRegistry(options => {
                options.ServiceId = Guid.NewGuid().ToString();
                options.ServiceName = "SeckillServices";
                //options.ServiceAddress = "http://172.18.0.14:80";
                //options.ServiceAddress = "http://10.96.0.14:5004";//k8s��Ⱥservice����
                options.ServiceAddress = "http://localhost:5045";
                options.HealthCheckAddress = "/HealthCheck";

                // options.RegistryAddress = "http://172.18.0.2:8500";
                //options.RegistryAddress = "http://10.96.0.2:8500";//k8s��Ⱥservice����
                options.RegistryAddress = "http://localhost:8500";
            });

            // 5����ӿ�����
            services.AddControllers(options => {
                options.Filters.Add<MiddlewareResultWapper>(); // 1��ͨ�ý��
                options.Filters.Add<BizExceptionHandler>();// 2��ͨ���쳣
                options.ModelBinderProviders.Add(new SysUserModelBinderProvider());// 3���Զ���ģ�Ͱ�
            }).AddNewtonsoftJson(options => {
                // ��ֹ����дת����Сд
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
