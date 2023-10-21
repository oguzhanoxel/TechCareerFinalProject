using DataAccess.Repositories;
using DataAccess.Repositories.Abstracts;
using FinalProjectFormsApp.Forms.OrderForms;
using FinalProjectFormsApp.Forms.OrderItemForms;
using FinalProjectFormsApp.Forms.ProductForms;
using FinalProjectFormsApp.Forms.ReportForms;
using FinalProjectFormsApp.Forms.UserForms;
using FinalProjectFormsApp.Forms.VehicleForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using Services.Services.Abstracts;
using Services.Validations;
using System;
using System.Windows.Forms;

namespace FinalProjectFormsApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            //using (LogisticsDbContext context = new LogisticsDbContext())
            //{
            //    context.SeedData();
            //}

            Application.Run(host.Services.GetRequiredService<LoginForm>());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Validators
                    services.AddTransient<UserValidator>();

                    // Repositories
                    services.AddTransient<IUserRepository, UserRepository>();
                    services.AddTransient<IVehicleRepository, VehicleRepository>();
                    services.AddTransient<IProductRepository, ProductRepository>();
                    services.AddTransient<IOrderRepository, OrderRepository>();
                    services.AddTransient<IOrderItemRepository, OrderItemRepository>();
                    services.AddTransient<IReportRepository, ReportRepository>();
                    
                    // Services
                    services.AddTransient<IUserService, UserService>();
                    services.AddTransient<IProductService, ProductService>();
                    services.AddTransient<IOrderService, OrderService>();
                    services.AddTransient<IOrderItemService, OrderItemService>();
                    services.AddTransient<IVehicleService, VehicleService>();
                    services.AddTransient<IReportService, ReportService>();

                    // Forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<RegisterForm>();
                    services.AddTransient<PasswordResetForm>();
                    services.AddTransient<UserEditForm>();
                    
                    services.AddTransient<LogisticsForm>();

                    services.AddTransient<VehicleCreateForm>();
                    services.AddTransient<VehicleEditForm>();

                    services.AddTransient<ProductCreateForm>();
                    services.AddTransient<ProductEditForm>();

                    services.AddTransient<OrderItemCreateForm>();

                    services.AddTransient<OrderCreateForm>();
                    services.AddTransient<OrderEditForm>();

                    services.AddTransient<ReportCreateForm>();

                    ServiceProvider = services.BuildServiceProvider();
                });

        public static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
    }
}
