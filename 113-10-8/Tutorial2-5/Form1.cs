namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void showback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;     //�]�wvisible�ݩʬ���
            ptxfront.Visible = false;
        }
        //��ܼ��J�P����
        private void showfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
