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
    public partial class Clerk : Form
    {
        public Clerk()
        {
            InitializeComponent();
            var list = PassengerHandling.GetHistory();
            foreach (var item in list)
            {
                string[] row = { item.ID.ToString(), item.Passenger.Name, item.PassportNumber.ToString(), item.TrainID.ToString()};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Reservation();
            //this.Hide();
            frm.Show();
            //frm.Closed += (hh, uu) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new AvailableTrains();
            //this.Hide();
            frm.Show();
        }
    }
}
