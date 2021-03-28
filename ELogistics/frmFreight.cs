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
    public partial class frmFreight : Form
    {
        // instatiat dataLayer.
        DataLayer data = new DataLayer();

        //global.
        int G_id ;

        public frmFreight()
        {
            InitializeComponent();
            getstatus();
        }

        void getstatus()
        {
            var st = data.All_Statuses();
            int size = st.Count;
            if (size > 0)
            {
                foreach (var item in st)
                {
                    txt_status.Items.Add(item.Id);
                }
            }
        }

        private void lbl_country_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // create new object.
                
                Freight  fr = new Freight()
                {
                    // incoming update
                    CustomerId = int.Parse(txt_c_number.Text.Trim()),
                    Height = txt_height.Text.Trim(),
                    Weight = txt_weight.Text.Trim(),
                    Lenght = txt_length.Text.Trim(),
                    DestinationAddressId = int.Parse(txt_destination.Text.Trim()),
                    OriginAddressId = int.Parse(txt_origin_address.Text.Trim()),
                    StatusId = int.Parse(txt_status.Text.Trim()),
                    Date = DateTime.Parse(txt_date.Text)
                };
                //call function
                bool status = data.Add_frieght(fr);
                if (status)
                {
                    //saved.
                    MessageBox.Show(" Frieght added");
                    read();
                }
                else
                {
                    //failed.
                    MessageBox.Show(" Failed to create Freight ");
                }
            }
            catch
            {
                MessageBox.Show(" Could not create Freight ");
            }

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            read();
           /* //fetch.
            Freight ft = data.Fetch_frieght(1);

            //check.
            if (ft != null)
            {
                // from db to texts boxes
                txt_c_number.Text = ft.CustomerId.ToString();
                txt_height.Text = ft.Height;
                txt_weight.Text = ft.Weight;
                txt_length.Text = ft.Lenght;
                txt_destination.Text = ft.DestinationAddressId.ToString();
                txt_origin_address.Text = ft.OriginAddressId.ToString();
                txt_status.Text = ft.StatusId.ToString();
                txt_date.Text = ft.Date.ToString() ;
            }
            else
            {
                MessageBox.Show(" Driver doesnt exist ");
            }*/

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //fetch.
            Freight fr = data.Fetch_frieght(G_id);

            //check.
            if (fr != null)
            {
                //create new object.
                Freight nfr = new Freight()
                {
                    // incoming update
                    CustomerId = int.Parse(txt_c_number.Text.Trim()),
                    Height = txt_height.Text.Trim(),
                    Weight = txt_weight.Text.Trim(),
                    Lenght = txt_length.Text.Trim(),
                    DestinationAddressId = int.Parse(txt_destination.Text.Trim()),
                    OriginAddressId = int.Parse(txt_origin_address.Text.Trim()),
                    StatusId = int.Parse(txt_status.Text.Trim()),
                    Date = DateTime.Parse(txt_date.Text)
                };

                //call update methode.
                var status = data.Update_frieght(fr, nfr);

                //check status
                if (status)
                {
                    MessageBox.Show(" Freight successfully updated ");
                    read();
                }
                else
                {
                    MessageBox.Show(" failed to update Freight ");
                }

            }
            else
            {
                MessageBox.Show(" Freight doesnt exist ");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //fetch.
            Freight ft = data.Fetch_frieght(G_id);

            //check.
            if (ft != null)
            {
                //delete.
                bool temp = data.Delete_frieght(ft);
                if (temp)
                {
                    MessageBox.Show(" Freight deleted ");
                    read();
                }
                else
                {
                    MessageBox.Show(" failed to delete Freight ");
                }

            }
            else
            {
                MessageBox.Show(" Freight doesnt exist ");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFreight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eLogisticsDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.eLogisticsDataSet.Status);

        }

        private void listf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_id = int.Parse(listf.SelectedItems[0].SubItems[0].Text);
                txt_c_number.Text = listf.SelectedItems[0].SubItems[1].Text;
                txt_height.Text = listf.SelectedItems[0].SubItems[2].Text;
                txt_length.Text = listf.SelectedItems[0].SubItems[3].Text;
                txt_weight.Text = listf.SelectedItems[0].SubItems[4].Text;
                txt_destination.Text = listf.SelectedItems[0].SubItems[5].Text;
                txt_status.Text = listf.SelectedItems[0].SubItems[6].Text;
                txt_origin_address.Text = listf.SelectedItems[0].SubItems[7].Text;
                txt_date.Text = listf.SelectedItems[0].SubItems[8].Text;


            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(" No Item selected ");
                G_id = -1;
            }

        }

        //read func.
        void read()
        {

            var dlist = data.All_Freights();
            int size = dlist.Count;

            if (listf != null)
            {
                listf.Items.Clear();
            }

            if (size > 0)
            {


                foreach (var driver in dlist)
                {
                    ListViewItem view = new ListViewItem(driver.Id.ToString(), 0);

                    view.SubItems.Add(driver.CustomerId.ToString());
                    view.SubItems.Add(driver.Height);
                    view.SubItems.Add(driver.Lenght);
                    view.SubItems.Add(driver.Weight);
                    view.SubItems.Add(driver.DestinationAddressId.ToString());
                    view.SubItems.Add(driver.StatusId.ToString());
                    view.SubItems.Add(driver.OriginAddressId.ToString());
                    view.SubItems.Add(driver.Date.ToString());
                    //add to list view.
                    listf.Items.Add(view);

                }
            }
            else
            {
                MessageBox.Show("NO Freights available.");
            }


        }
    }
}
