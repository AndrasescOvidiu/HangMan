using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangMan
{
    public partial class highscore : Form
    {
        public highscore()
        {
            InitializeComponent();
        }

        private void highscore_Load(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader("HighScores.txt");
            string info = "";
            while((info=rd.ReadLine())!=null)
            {
                string[] finalForm = info.Split('|');
                listBox1.Items.Add(finalForm[0]+" || score: "+finalForm[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
