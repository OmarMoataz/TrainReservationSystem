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
    public partial class AddTrain : Form
    {
        public AddTrain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainHandling.AddNewTrain(txtFrom.Text, txtTo.Text, txtDepDate.Text, txtArrDate.Text, int.Parse(txtCarsNum.Text));
            
            var frm = new AddTrain();
            this.Hide();
            frm.Closed += (hh, uu) => this.Close(); 
        }

        private void AddTrain_Load(object sender, EventArgs e)
        {

        }

       
    }
}
