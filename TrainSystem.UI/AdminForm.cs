//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using TrainSystem.BLL;
//namespace TrainSystem.UI
//{
//    public partial class AdminForm : Form
//    {
//        public AdminForm()
//        {
//            InitializeComponent();
//            var list = TrainHandling.ViewAllTrains();
//            foreach (var item in list)
//            {
//                string[] row = {item.ID.ToString(), item.DepartureDate, item.ArrivalDate,item.StartingStation,item.EndingStation,item.NumberOfCars.ToString(),item.AvailableSeats.ToString()};
//                var listViewItem = new ListViewItem(row);
//                listView1.Items.Add(listViewItem);
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            var frm = new AddTrain();
//            this.Hide();
//            frm.Closed += (hh, uu) => this.Close(); 
//            frm.Show();
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {

//            var frm = new AddTrain();
//            frm.Show();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            int x;
//            bool t = int.TryParse(txtTrainID.Text, out x);
//            if(t)
//            {
//                var train = TrainHandling.GetTrainById(x);
//                if(train==null)
//                {
//                    MessageBox.Show("Invalid Train ID");
//                }
//                else
//                {
//                    EditTrain tr = new EditTrain();
//                    tr.Init(x, train.StartingStation, train.EndingStation, 
//                        train.DepartureDate, train.ArrivalDate, train.NumberOfCars);
//                    tr.Show();
//                }
                
//            }
//            else MessageBox.Show("Invalid Train ID");
//        }

//        private void AdminForm_Load(object sender, EventArgs e)
//        {

//        }

//        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

        
//    }
//}
