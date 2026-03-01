using ERP_FRONT.Views.Main;

namespace ERP_FRONT
{
    public partial class MainContainer : Form, IMainForm
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        public event EventHandler EventClicked;

        public Form GetContainer() => this;

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
