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
    public partial class EditTrain : Form
    {
        int Id;
        public EditTrain()
        {
            InitializeComponent();
            
        }
         public void Init(int id,string from, string to, string depdate, string arrdate, long carsnum)
        {
            txtFrom.Text = from;
            txtTo.Text = to;
            txtDepDate.Text = depdate;
            txtDepDate.Text = depdate;
            txtArrDate.Text = arrdate;
            txtCarsNum.Text = carsnum.ToString();
            Id = id;
        }

         private void button1_Click(object sender, EventArgs e)
         {
             TrainHandling.EditTrain(Id,txtFrom.Text, txtTo.Text, txtDepDate.Text, txtArrDate.Text, int.Parse(txtCarsNum.Text));
             var frm = new EditTrain();
             this.Hide();
             frm.Closed += (hh, uu) => this.Close(); 
         }
    }
}
