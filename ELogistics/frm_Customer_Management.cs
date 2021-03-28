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
    public partial class frm_Customer_Management : Form
    {
        // instatiate data class.
        DataLayer dl = new DataLayer();

        int G_id;


        public frm_Customer_Management()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cs = new Customer()
                {
                    FullName = txt_fullname.Text.Trim(),
                    ContactNumber = txt_contactnumber.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    AddressId = null
                };

                //call function
                bool status = dl.add_customer(cs);
                if (status)
                {
                    //saved.
                    MessageBox.Show(" Customer successfully added ");
                }
                else
                {
                    //failed.
                    MessageBox.Show(" Failed to Add Customer ");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" something wrong with the inputs ");
            }

        }
        //cls
        void cls()
        {
            txt_fullname.Text = "";
            txt_contactnumber.Text = "";
            txt_email.Text = "";
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //read.
            read();
          /*  //fetch.
            Customer ft = dl.fetch_customer(txt_email.Text.Trim());

            //check.
            if (ft != null)
            {
                txt_fullname.Text = ft.FullName;
                txt_contactnumber.Text = ft.ContactNumber;
                txt_email.Text = ft.Email;
            }
            else
            {
                MessageBox.Show(" Customer does not exist ");
            }*/
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //fetch.
            Customer ft = dl.fetch_customer(txt_email.Text.Trim());

            //check.
            if (ft != null)
            {
                // create new object.
                Customer cs = new Customer()
                {
                    FullName = txt_fullname.Text.Trim(),
                    ContactNumber = txt_contactnumber.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    AddressId = null
                };

                //call update methode.
                var status = dl.update_customer(ft, cs);

                //check status
                if (status)
                {
                    MessageBox.Show(" Customer successfully updated ");
                    read();
                }
                else
                {
                    MessageBox.Show(" Customer failed to update");
                }

            }
            else
            {
                MessageBox.Show(" Customer doesnt exist ");

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //fetch.
            Customer ft = dl.fetch_customer(txt_email.Text.Trim());

            //check.
            if (ft != null)
            {
                //delete.
                bool temp = dl.delete_cutomer(ft);
                if (temp)
                {
                    MessageBox.Show(" Customer deleted ");
                    read();
                }
                else
                {
                    MessageBox.Show(" failed to delete Customer ");
                }

            }
            else
            {
                MessageBox.Show(" Customer doesnt exist ");
            }
        }

        private void listdriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_id = int.Parse(listcustomer.SelectedItems[0].SubItems[0].Text); ;
                txt_fullname.Text = listcustomer.SelectedItems[0].SubItems[1].Text;
                txt_contactnumber.Text = listcustomer.SelectedItems[0].SubItems[2].Text;
                txt_email.Text = listcustomer.SelectedItems[0].SubItems[3].Text;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" No Item selected ");
                G_id = -1;
            }

        }

        //
        void read()
        {

            var dlist = dl.All_Customers();

            if (listcustomer != null)
            {
                listcustomer.Items.Clear();
            }

            foreach (var driver in dlist)
            {
                ListViewItem view = new ListViewItem(driver.Id.ToString(), 0);
                view.SubItems.Add(driver.FullName);
                view.SubItems.Add(driver.ContactNumber);
                view.SubItems.Add(driver.Email);

                //add to list view.
                listcustomer.Items.Add(view);

            }
        }
    }
}
