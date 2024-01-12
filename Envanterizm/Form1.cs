using System.IO;
using System.Windows.Forms;

namespace Envanterizm
{
    public partial class Envanterizm : Form
    {
        public Envanterizm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string ad = textBox2.Text;
            string adet = textBox3.Text;
            string fiyat = textBox4.Text;
            listBox1.Items.Add(id + "   " + ad + "   " + adet + "   " + fiyat);
            MessageBox.Show("Veri Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            const string SPath = "kaydedilenler.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(SPath);

            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.ToString();
            SaveFile.Close();

            MessageBox.Show("Programs saved!");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string SPath = "kaydedilenler.txt";
            try
            {
                try
                {

                    string[] lines = System.IO.File.ReadAllLines(SPath);

                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }

                }
                catch { }
            }
            catch { }

        }

        private void Envanterizm_Load(object sender, EventArgs e)
        {
            const string SPath = "kaydedilenler.txt";
            try
            {
                try
                {

                    string[] lines = System.IO.File.ReadAllLines(SPath);

                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }

                }
                catch { }
            }
            catch { }

        }
    }
}
