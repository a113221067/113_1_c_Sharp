namespace Textboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblshow_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;

            firstName =txtfirstname.Text;
            lastName =txtlastname.Text;
            firstName =lastName + "" + firstName;

            lblshow.Text = fullName;
        }
    }
}
