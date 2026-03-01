using ERP_FRONT.Services.Navigation;
using ERP_FRONT.Views.Main;
using ERP_FRONT.Views.Register;

namespace ERP_FRONT.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainForm _mainForm;
        private readonly INavigationService _navigationService;

        public MainPresenter(IMainForm mainForm, INavigationService navigationService)
        {
            this._mainForm = mainForm;
            this._navigationService = navigationService;

            _mainForm.EventClicked += OnEventClicked;
        }

        public void OnEventClicked(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<RegisterForm>();
        }
    }
}
