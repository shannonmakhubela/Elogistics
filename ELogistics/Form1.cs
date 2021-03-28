using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ELogisticsLibrary;

namespace ELogistics
{
    public partial class Ctu : Form
    {
        //Logging lg = new Logging() ;

        public Ctu()
        {
            InitializeComponent();
           // Logging lg = new Logging();
        }

        private void address_Click(object sender, EventArgs e)
        {
            frmAddress ad = new frmAddress();
            ad.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            frm_Customer_Management cus = new frm_Customer_Management();
            cus.Show();
        }

        private void freight_Click(object sender, EventArgs e)
        {
            frmFreight fr = new frmFreight();
            fr.Show();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            FrmDriver dr = new FrmDriver();
            dr.Show();
        }

        private void statuses_Click(object sender, EventArgs e)
        {
            FrmStatus st = new FrmStatus();
            st.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            //System.Windows.Forms.Application.Exit();
            string msg = " Select OK if you wish to exit the application or CANCEL if you wish to stay ";
            string tittle = " Exit Ctu ";
            MessageBoxButtons butt = MessageBoxButtons.OKCancel;
            DialogResult res = MessageBox.Show(msg,tittle,butt);

            if (res == DialogResult.OK)
            {
                this.Close();
            }
            else 
            {
                // nothing
            }
        }
    }
}
