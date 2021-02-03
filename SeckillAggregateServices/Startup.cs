using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Projects.Common.Caches;
using Projects.Common.Distributes;
using Projects.Common.Exceptions.Handlers;
using Projects.Common.Filters;
using Projects.Common.Users;
using Projects.Cores.MicroClient.Extensions;
using SeckillAggregateServices.Caches.SeckillStock;
using SeckillAggregateServices.Context;
using SeckillAggregateServices.Luas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeckillAggregateServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //1.ע��΢����ͻ��ˣ���̬��̨���������֡������ؾ��⡪����̨����PollyHttpClient��
            services.AddMicroClient(options =>
            {
                options.AssemblyName = "SeckillAggregateServices";
                options.dynamicMiddlewareOptions = mo =>
                  {
                      mo.serviceDiscoveryOptions = sdo =>
                        {
                            sdo.DiscoveryAddress = "http://localhost:8500";
                        };
                  };
            });

            //2.���ÿ���
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.SetIsOriginAllowed(_=>true).AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });

            //3.��������֤
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "https://localhost:5005";//1.��Ȩ���ĵ�ַ
                    options.ApiName = "Services";//2.Api����
                    options.RequireHttpsMetadata = false;//3.httpsԪ���ݲ���Ҫ
                });

            //4.��ӿ�����
            services.AddControllers(options =>
            {
                options.Filters.Add<FrontResultWapper>();//1.ͨ�ý��
                options.Filters.Add<BizExceptionHandler>();//2.ͨ���쳣
                options.ModelBinderProviders.Insert(0, new SysUserModelBinderProvider());//3.�Զ����ģ��
            }).AddNewtonsoftJson(options =>
            {
                //��ֹ��дת����Сд
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                //options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            //5.ʹ���ڴ滺��
            services.AddMemoryCache();

            //5.1.ʹ��redis�ֲ�ʽ����
            services.AddDistributedRedisCache("localhost:6379, password =, defaultDatabase = 2, poolsize = 50, connectTimeout = 5000, syncTimeout = 10000, prefix = seckill_stock_");

            //6 ʹ����ɱ��滺��
            //services.AddSeckillStockCache();
            //6.1 ʹ����ɱredis��滺��
            services.AddRedisSeckillStockCache();

            //7.����¼�����
            services.AddCap(x =>
            {
                //7.1ʹ���ڴ�洢��Ϣ����Ϣ����ʧ�ܴ���
                x.UseInMemoryStorage();
                //7.2ʹ��EntityFramework���д洢����
                //x.UseEntityFramework<SeckillAggregateServicesContext>();
                //7.3ʹ��mysql����������
                //x.UseMySql(Configuration.GetConnectionString("DefaultConnection"));
                //7.4ʹ��rabbitmq�����¼����Ĵ���
                x.UseRabbitMQ(rb =>
                {
                    rb.HostName = "localhost";
                    rb.UserName = "guest";
                    rb.Password = "guest";
                    rb.Port = 5672;
                    rb.VirtualHost = "/";
                });
                //7.5ʹ�ú�̨���ҳ��
                x.UseDashboard();
            });

            //8.���dbcontext
            services.AddDbContextPool<SeckillAggregateServicesContext>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
            });

            //9.����seckillLua�ļ�
            services.AddHostedService<SeckillLuaHostedService>();

            //10��ӷֲ�ʽ����
            services.AddDistributedOrderSn(1, 1);


            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //2.ʹ�ÿ���
            app.UseCors("AllowSpecificOrigin");

            app.UseHttpsRedirection();

            app.UseRouting();

            //1.���������֤
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
