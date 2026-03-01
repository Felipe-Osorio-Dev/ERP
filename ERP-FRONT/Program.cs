using ERP_FRONT.Presenters;
using ERP_FRONT.Services.Navigation;
using ERP_FRONT.Views.Main;
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
                serviceProvider.GetRequiredService<MainPresenter>();
                
                Application.Run(mainContainer);
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //MainContainer
            services.AddSingleton<MainContainer>();

            //Interfaces
            services.AddTransient<IMainForm>(sp => sp.GetRequiredService<MainContainer>());

            //Forms

            //Presenters
            services.AddSingleton<MainPresenter>();

            //Navigation
            services.AddSingleton<INavigationService, NavigationService>();
        }
    }
}