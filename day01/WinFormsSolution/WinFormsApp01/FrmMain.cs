namespace WinFormsApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다.");
        }
    }
}
