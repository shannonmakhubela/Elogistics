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
    public partial class frmAddress : Form
    {
        //instatiate data layer class.
        DataLayer data = new DataLayer();
        //global
        int G_id ;
        

        public frmAddress()
        {
            InitializeComponent();
        }

        private void address_information_Enter(object sender, EventArgs e)
        {

        }

        // create address.
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Address ad = new Address()
                {
                    //Id = 1,
                    ComplexNumber = txt_c_number.Text.Trim(),
                    ComplexName = txt_c_name.Text.Trim(),
                    Street = txt_street.Text.Trim(),
                    Suburb = txt_suburb.Text.Trim(),
                    City = txt_city.Text.Trim(),
                    Province = txt_province.Text.Trim(),
                    Country = txt_country.Text.Trim(),
                    PostalCode = txt_postalcode.Text.Trim(),
                };

                // save data.
                bool ret = data.Insert_Address(ad);
                if (ret)
                {
                    //saveed.
                    MessageBox.Show(" Address successfully saved. ");
                    clear();
                }
                else
                {
                    //not saved.
                    MessageBox.Show(" failed to save Address ");
                    clear();
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" somthing wrong with inputs ");

            }

        }



        //clear textboxes.
        void clear()
        {
            txt_c_name.Text = "";
            txt_c_name.Text = "";
            txt_street.Text = "";
            txt_suburb.Text = "";
            txt_city.Text   = "";
            txt_province.Text = "";
            txt_country.Text  = "";
            txt_postalcode.Text = "";
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            // which/whose address am i reading ? all ?
            read();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //fetch.
            Address oldAD = data.fetch_Address(G_id);

            //check.
            if (oldAD != null)
            {
                //create new object.
                Address newAD = new Address()
                {

                    ComplexNumber = txt_c_number.Text.Trim(),
                    ComplexName = txt_c_name.Text.Trim(),
                    Street = txt_street.Text.Trim(),
                    Suburb = txt_suburb.Text.Trim(),
                    City =  txt_city.Text.Trim(),
                    Province =  txt_province.Text.Trim(),
                    Country =  txt_country.Text.Trim(),
                    PostalCode = txt_postalcode.Text.Trim()
            };
                
                //call update methode.
                var status = data.update_address(newAD, oldAD);

                //check status
                if (status)
                {
                    MessageBox.Show(" Address successfully updated ");
                    read();
                }
                else
                {
                    MessageBox.Show(" Failed to update Address ");
                }

            }
            else
            {
                MessageBox.Show(" Address doesnt exist ");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //fetch.
            Address ft = data.fetch_Address(G_id);

            //check.
            if (ft != null)
            {
                //delete.
                bool temp = data.delete_Address(ft);
                if (temp)
                {
                    MessageBox.Show(" Address deleted ");
                    //reload the list
                    read();
                }
                else
                {
                    MessageBox.Show(" failed to delete Address ");
                }

            }
            else
            {
                MessageBox.Show(" Address doesnt exist ");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_id = int.Parse(listaddress.SelectedItems[0].SubItems[0].Text);
                txt_c_number.Text = listaddress.SelectedItems[0].SubItems[1].Text;
                txt_c_name.Text = listaddress.SelectedItems[0].SubItems[2].Text;
                txt_street.Text = listaddress.SelectedItems[0].SubItems[3].Text;
                txt_suburb.Text = listaddress.SelectedItems[0].SubItems[4].Text;
                txt_city.Text = listaddress.SelectedItems[0].SubItems[5].Text;
                txt_province.Text = listaddress.SelectedItems[0].SubItems[6].Text;
                txt_country.Text = listaddress.SelectedItems[0].SubItems[7].Text;
                txt_postalcode.Text = listaddress.SelectedItems[0].SubItems[8].Text;


            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" No Item selected ");
                G_id = -1;
            }

        }

        //read.
        void read()
        {

            var dlist = data.All_Adress();

            if (listaddress != null)
            {
                listaddress.Items.Clear();
            }

            foreach (var item in dlist)
            {
                ListViewItem view = new ListViewItem(item.Id.ToString(), 0);
                view.SubItems.Add(item.ComplexNumber);
                view.SubItems.Add(item.ComplexName);
                view.SubItems.Add(item.Street);
                view.SubItems.Add(item.Suburb);
                view.SubItems.Add(item.City);
                view.SubItems.Add(item.Province);
                view.SubItems.Add(item.Country);
                view.SubItems.Add(item.PostalCode);

                //add to list view.
                listaddress.Items.Add(view);

            }
        }
    }
}
