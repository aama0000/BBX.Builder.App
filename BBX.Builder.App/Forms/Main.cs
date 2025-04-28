using BBX.Builder.App.Forms;

namespace BBX.Builder.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            new BuildForm().ShowDialog();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            new DatabaseForm().ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }
    }
}
