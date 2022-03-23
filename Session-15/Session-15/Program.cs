using Microsoft.Extensions.DependencyInjection;
using PetShopLib.Impl;
using Session15.EF.Repositories;

namespace Session_15
{
    internal static class Program
    {


        public static IServiceProvider ServiceProvider { get; private set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Employee>, MockEmployeeRepo>();
            services.AddSingleton<Main>();

            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<Main>();



            Application.Run(mainForm);
        }
    }
}