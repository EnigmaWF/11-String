using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = "яблоко";
            label1.Text = "яблоко ==>  " + (t.Remove(0,1).Remove(4))+ " и " + t.Remove(0,3);
            /*11.Из слова яблоко путем «вырезок» и «склеек» получить слова блок и око.*/
        }
    }
}
