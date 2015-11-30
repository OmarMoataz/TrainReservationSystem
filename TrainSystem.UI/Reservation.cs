using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainSystem.BLL;

namespace TrainSystem.UI
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool t1 = int.TryParse((textBox1.Text), out num1);
            bool t2 = int.TryParse((textBox2.Text), out num2);
            if (t1 && t2)
                PassengerHandling.ReserveChair(num1, num2, textBox3.Text);
            else MessageBox.Show("Invalid Input");
        }
    }
}
