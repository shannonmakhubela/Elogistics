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
    public partial class FrmDriver : Form
    {
        //create DataLayer.
        DataLayer data = new DataLayer();
        // Global ID
        int G_id ;

        public FrmDriver()
        {
            InitializeComponent();
            StatusInit();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // create new object.
                Driver driver = new Driver()
                {
                    FullName = txt_fullname.Text.Trim(),
                    LicenseType = ltype.Text,
                    Owner = selectOwner()
                };

                //call function
                bool status = data.add_driver(driver);
                if (status)
                {
                    //saved.
                    MessageBox.Show(" Driver added");
                }
                else
                {
                    //failed.
                    MessageBox.Show(" Failed to Add Driver ");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" Somothing  wrong with the inputs ");
            }
        }

        //initialize status.
        void StatusInit()
        {
            ltype.Items.Add("Type1");
            ltype.Items.Add("Type2");
            ltype.Items.Add("Type3");
        }

        bool selectOwner()
        {
            bool temp = false;
            if (yes_check.Checked)
            {
                temp = true;
            }
            if (no_check.Checked)
            {
                temp = false;
            }

            return temp;

        }

        private void yes_check_CheckedChanged(object sender, EventArgs e)
        {
            if (yes_check.Checked == true)
            {
                no_check.Checked = false;
            }
        }

        private void no_check_CheckedChanged(object sender, EventArgs e)
        {
            if (no_check.Checked == true)
            {
                yes_check.Checked = false;
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //empty lv fist
           
            read();
            //fetch.
         /*   Driver ft = data.fetch_driver(2);

            //check.
            if (ft != null)
            {
                txt_fullname.Text = ft.FullName;
                ltype.Text = ft.LicenseType;
                string temp = ft.Owner.ToString();
                bool st = Convert.ToBoolean(temp);

                  if (st)
                  {
                      yes_check.Checked = true;
                }
                  else
                  {
                      no_check.Checked = true;
                }
            }
            else
            {
                MessageBox.Show(" Driver doesnt exist ");
            }*/

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //fetch.
            Driver ft = data.fetch_driver(G_id);

            //check.
            if (ft != null)
            {
                //delete.
                bool temp = data.delete_driver(ft);
                if (temp)
                {
                    MessageBox.Show(" Driver deleted ");
                    //reload the list
                    read();
                }
                else
                {
                    MessageBox.Show(" failed to delete Driver ");
                }

            }
            else
            {
                MessageBox.Show(" Driver doesnt exist ");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            //fetch.
            Driver ft = data.fetch_driver(G_id);

            //check.
            if (ft != null)
            {
                //create new object.
                Driver dr = new Driver()
                {
                    FullName = txt_fullname.Text.Trim(),
                    LicenseType = ltype.Text,
                    Owner = selectOwner()
                };

                //call update methode.
                var status = data.update_driver(ft,dr);

                //check status
                if (status)
                {
                    MessageBox.Show(" Driver successfully updated ");
                }
                else
                {
                    MessageBox.Show(" Driver successfully updated ");
                }

            }
            else
            {
                MessageBox.Show(" Driver doesnt exist ");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //exit.
            this.Close();
        }

        void read()
        {
           
            var dlist = data.All_Drivers();

            if (listdriver != null)
            {
                listdriver.Items.Clear();
            }

            foreach (var driver in dlist)
            {
                ListViewItem view = new ListViewItem( driver.Id.ToString() , 0);
                view.SubItems.Add(driver.FullName);
                view.SubItems.Add(driver.LicenseType);
                view.SubItems.Add(driver.Owner.ToString());

                //add to list view.
                listdriver.Items.Add(view);

            }
        }

        private void listdriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_id = int.Parse(listdriver.SelectedItems[0].SubItems[0].Text); 
                txt_fullname.Text = listdriver.SelectedItems[0].SubItems[1].Text;
                ltype.Text = listdriver.SelectedItems[0].SubItems[2].Text;
                bool selected_owner = Convert.ToBoolean(listdriver.SelectedItems[0].SubItems[3].Text);
                if (selected_owner)
                {
                    yes_check.Checked = true;
                }
                else
                {
                    no_check.Checked = true;
                }

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" No Item selected ");
                G_id = -1;
            }

            
           
        }
    }
}
