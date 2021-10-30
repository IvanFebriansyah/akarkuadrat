using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akarkuadrat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
           
            kalkulasi kal = new kalkulasi();
            kal.a = double.Parse(textBox1.Text);
            kal.hitung();
            label3.Text = kal.hasil1;


        }
    }
}
