using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_WinForms_
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random random;
        char[] special_Chars = new char[] { '%', ')', '(', '?', '#', '$', '^', '_' };
        Dictionary<string, double> metrica;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты содержит ряд небольших программ, которые могут пригодится в жизни. А главное могут научить меня основам программирования на С#.\n\nАвтор: Мисюро Никита", "О программе");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotePad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonGeneration_Click(object sender, EventArgs e)
        {
            int n; 
            n = random.Next(Convert.ToInt32(numericUpDownOt.Value), Convert.ToInt32(numericUpDownDo.Value));
            labelOutput.Text = n.ToString();
            
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tsmiData_Click(object sender, EventArgs e)
        {
          rtbNotepad.AppendText("\n" + DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText("\n" + DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при сохранении");
            }
            
        }
        void LoadNotePad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке");
            }
        }
        private void tsmiSetup_Click(object sender, EventArgs e)
        {
            LoadNotePad();
        }

        private void tsmiDeleteAll_Click(object sender, EventArgs e)
        {
            rtbNotepad.Clear();
        }

        private void rtbNotepad_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPassLEngth.Value; i++)
            {
                int n = random.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        password += random.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(random.Next(65, 90));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(random.Next(97, 122));
                        break;
                    default:
                        password += special_Chars[random.Next(special_Chars.Length)];
                        break;        
                }
                tbOutput.Text = password;
            }
        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nudPassLEngth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSwap_Click_1(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }
    }
}
