namespace ERP_FRONT.Services.Navigation
{
    internal interface INavigationService
    {
        void NavigateTo<TForm>() where TForm : Form, new();
    }
}
