namespace Latih11_KonekDbDapper
{
    public partial class Form1 : Form
    {
        private readonly NilaiDal nilaiDal;
        public List<string> list;
        public Form1()
        {
            InitializeComponent();
            nilaiDal = new NilaiDal();
            list = new List<string>()
            {
                "All","Diatas KKM","Dibawah KKM"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nilaiDal.ListData();

            comboBox1.DataSource = list;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ngelist();
        }

        public void Ngelist()
        {
            var a = nilaiDal.ListData();
            int nilai = 0;
            if (comboBox1.SelectedIndex == 1)
            {
                nilai = 75;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var fil = a.Where(x => x.Nilai < 75).ToList();
                dataGridView1.DataSource = fil;
                return;
            }
            var filter = a.Where(x => x.Nilai >= nilai).ToList();
            dataGridView1.DataSource = filter;
        }

    }
}
