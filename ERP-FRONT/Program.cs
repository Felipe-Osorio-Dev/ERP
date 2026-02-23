using Microsoft.Extensions.DependencyInjection;

namespace ERP_FRONT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainContainer = serviceProvider.GetRequiredService<MainContainer>();
                
                Application.Run(mainContainer);
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //MainContainer
            services.AddSingleton<MainContainer>();
        }
    }
}