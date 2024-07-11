namespace Latih11_KonekDbDapper
{
    public partial class Form1 : Form
    {
        private readonly NilaiDal nilaiDal;
        public Form1()
        {
            InitializeComponent();
            nilaiDal = new NilaiDal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nilaiDal.ListData();
            
        }
    }
}
