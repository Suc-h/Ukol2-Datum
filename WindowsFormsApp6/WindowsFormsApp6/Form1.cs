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
        public DateTime cas1 = new DateTime();
        public DateTime cas2 = new DateTime();
        
            
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
            cas1 = DateTime.Now;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            cas2 = DateTime.Now;
            TimeSpan time= cas2 - cas1;
            MessageBox.Show("Uběhlo sekund: "+time.Seconds);
            MessageBox.Show("Uběhlo minut: " + time.Minutes);
        }
    }
}
