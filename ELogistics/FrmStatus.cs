using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELogistics
{
    public partial class FrmStatus : Form
    {
        //instatiate datal
        DataLayer dl = new DataLayer();

        //status Global id.
        int G_id ;

        public FrmStatus()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // create new object.
                Status st = new Status()
                {
                    Status1 = txt_status_id.Text.Trim(),
                    DriverId = int.Parse(txt_driver_id.Text.Trim()),
                    DatePickedUp = DateTime.Parse(txt_datepicked.Text),
                    DateDelivered = DateTime.Parse(txt_delivereddate.Text),
                };

                //call function
                bool status = dl.Add_status(st);
                if (status)
                {
                    //saved.
                    MessageBox.Show(" Status Created ");
                }
                else
                {
                    //failed.
                    MessageBox.Show(" Failed to create Status ");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" Some thing wrong with inputs ");
            }

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //read ;
            read();
            /*//fetch.
            Status st = dl.Fetch_status(G_id);

            //check.
            if (st != null)
            {
                txt_status_id.Text = st.Status1;
                txt_driver_id.Text = st.DriverId.ToString();
                txt_datepicked.Text = st.DatePickedUp.ToString(); 
                txt_delivereddate.Text = st.DateDelivered.ToString();
            }
            else
            {
                MessageBox.Show(" Status does not exist ");
            } */
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //fetch.
            Status st = dl.Fetch_status(G_id);

            //check.
            if (st != null)
            {
                //create new object.
                Status nst = new Status()
                {
                    Status1 = txt_status_id.Text.Trim(),
                    DriverId = int.Parse(txt_driver_id.Text.Trim()),
                    DatePickedUp = DateTime.Parse(txt_datepicked.Text),
                    DateDelivered = DateTime.Parse(txt_delivereddate.Text),
                };

                //call update methode.
                var status = dl.Update_status(st, nst);

                //check status
                if (status)
                {
                    MessageBox.Show(" Status successfully updated ");
                    read();
                }
                else
                {
                    MessageBox.Show(" Status successfully updated ");
                }

            }
            else
            {
                MessageBox.Show(" Status doesnt exist ");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //fetch.
            Status ft = dl.Fetch_status(G_id);

            //check.
            if (ft != null)
            {
                //delete.
                bool temp = dl.Delete_status(ft);
                if (temp)
                {
                    MessageBox.Show(" Status deleted ");
                    read();
                }
                else
                {
                    MessageBox.Show(" Status to delete Driver ");
                }

            }
            else
            {
                MessageBox.Show(" Status does not exist ");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liststatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_id = int.Parse(liststatus.SelectedItems[0].SubItems[0].Text); ;
                txt_status_id.Text = liststatus.SelectedItems[0].SubItems[1].Text;
                txt_driver_id.Text = liststatus.SelectedItems[0].SubItems[2].Text;
                txt_datepicked.Text = liststatus.SelectedItems[0].SubItems[3].Text;
                txt_delivereddate.Text = liststatus.SelectedItems[0].SubItems[4].Text;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" No Item selected ");
                G_id = -1;
            }
        }

        // read.
        void read()
        {

            var dlist = dl.All_Statuses();
            int size = dlist.Count;

            if (liststatus != null)
            {
                liststatus.Items.Clear();
            }

            if (size > 0)
            {


                foreach (var driver in dlist)
                {
                    ListViewItem view = new ListViewItem(driver.Id.ToString(), 0);
                    
                    view.SubItems.Add(driver.Status1);
                    view.SubItems.Add(driver.DriverId.ToString());
                    view.SubItems.Add(driver.DatePickedUp.ToString());
                    view.SubItems.Add(driver.DateDelivered.ToString());
                    //add to list view.
                    liststatus.Items.Add(view);

                }
            }
            else
            {
                MessageBox.Show("NO status available.");
            }


        }


    }
}
