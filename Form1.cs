using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ozellik yeni = new ozellik();
            // this.Text = yeni.mudur; // get blogu devreye girdi
            yeni.mudur = "ahmet akın "; // set blogu devreye girdi
            this.Text = yeni.mudur; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ozellik yeni = new ozellik();
            // this.Text = yeni.mudur;
            yeni.mudur = "ahmet akın ";
            yeni.butcemiktari = textBox1.Text;
            this.Text = yeni.mudur + "'nın limiti " + yeni.butcemiktari + " dır."; 
        }
    }
}
