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
    public partial class AvailableTrains : Form
    {
        public AvailableTrains()
        {
            InitializeComponent();
            var list = TrainHandling.ViewTrains();
            foreach (var item in list)
            {
                string[] row = { item.ID.ToString(), item.DepartureDate, item.ArrivalDate, item.StartingStation, item.EndingStation, item.NumberOfCars.ToString(), item.AvailableSeats.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
