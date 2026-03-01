using ERP_FRONT.Views.Main;

namespace ERP_FRONT.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IMainForm _mainForm;
        private readonly Form _container;

        public NavigationService(IMainForm mainForm)
        {
            this._mainForm = mainForm;

            _container = mainForm.GetContainer();
        }

        public void NavigateTo<TForm>() where TForm : Form, new()
        {
            var existingForm = _container.MdiChildren.FirstOrDefault(f => f is TForm);

            if (existingForm != null)
            {
                existingForm.Activate();
            }
            else
            {
                var form = new TForm();
                form.MdiParent = _container;
                form.Show();
            }
        }
    }
}
