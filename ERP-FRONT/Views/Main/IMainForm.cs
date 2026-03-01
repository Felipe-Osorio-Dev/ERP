namespace ERP_FRONT.Views.Main
{
    internal interface IMainForm
    {
        event EventHandler EventClicked;

        Form GetContainer();
    }
}
