using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 12)
            {
                if (textBox1.Text.StartsWith("MDU_"))
                {
                    DirMaker maker1 = new DirMaker();
                    maker1.CreateDirectory(textBox1.Text);
                    MessageBox.Show(maker1.Result);
                }
                else
                {
                    info_label2.Visible = true;
                    info_label2.ForeColor = Color.Red;
                    info_label2.Text = @"Вы ввели неправильное название. 
Пример: MDU_KHA00078";
                }
            }
            if (textBox1.Text.Length < 12)
            {
                info_label2.Visible = true;
                info_label2.ForeColor = Color.OrangeRed;
                info_label2.Text = @"Вы ввели недостаточно символов!
                    не менее 12";
            }
        }
    }
}
