using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TrainSystem.BLL;

namespace TrainSystem.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Login.Loging(textBox1.Text, textBox2.Text, false))
            {
                var frm = new Clerk();
                this.Hide();
                
                frm.Closed += (sender_, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Admin Username Or Password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Loging(textBox1.Text, textBox2.Text, true))
            {
                var frm = new AdminFormEmergency();
                this.Hide();
                frm.Closed += (sender_, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Admin Username Or Password.");
            }
        }
    }
}
