namespace ELogistics
{
    partial class frmAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.address_information = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_c_name = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_province = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_postalcode = new System.Windows.Forms.TextBox();
            this.txt_c_number = new System.Windows.Forms.TextBox();
            this.lbl_c_name = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_suburb = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_province = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_postalcode = new System.Windows.Forms.Label();
            this.lbl_c_number = new System.Windows.Forms.Label();
            this.listaddress = new System.Windows.Forms.ListView();
            this.ad_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_complexnuum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_complexname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_sub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad_postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // address_information
            // 
            this.address_information.Controls.Add(this.btn_exit);
            this.address_information.Controls.Add(this.btn_read);
            this.address_information.Controls.Add(this.btn_update);
            this.address_information.Controls.Add(this.btn_delete);
            this.address_information.Controls.Add(this.btn_create);
            this.address_information.Controls.Add(this.txt_c_name);
            this.address_information.Controls.Add(this.txt_street);
            this.address_information.Controls.Add(this.txt_suburb);
            this.address_information.Controls.Add(this.txt_city);
            this.address_information.Controls.Add(this.txt_province);
            this.address_information.Controls.Add(this.txt_country);
            this.address_information.Controls.Add(this.txt_postalcode);
            this.address_information.Controls.Add(this.txt_c_number);
            this.address_information.Controls.Add(this.lbl_c_name);
            this.address_information.Controls.Add(this.lbl_street);
            this.address_information.Controls.Add(this.lbl_suburb);
            this.address_information.Controls.Add(this.lbl_city);
            this.address_information.Controls.Add(this.lbl_province);
            this.address_information.Controls.Add(this.lbl_country);
            this.address_information.Controls.Add(this.lbl_postalcode);
            this.address_information.Controls.Add(this.lbl_c_number);
            this.address_information.Location = new System.Drawing.Point(12, 12);
            this.address_information.Name = "address_information";
            this.address_information.Size = new System.Drawing.Size(856, 195);
            this.address_information.TabIndex = 0;
            this.address_information.TabStop = false;
            this.address_information.Text = "Address information:";
            this.address_information.Enter += new System.EventHandler(this.address_information_Enter);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(774, 158);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(536, 158);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 19;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(617, 158);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(693, 158);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(455, 160);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_c_name
            // 
            this.txt_c_name.Location = new System.Drawing.Point(171, 82);
            this.txt_c_name.Name = "txt_c_name";
            this.txt_c_name.Size = new System.Drawing.Size(128, 20);
            this.txt_c_name.TabIndex = 15;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(171, 108);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(128, 20);
            this.txt_street.TabIndex = 14;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(171, 134);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(128, 20);
            this.txt_suburb.TabIndex = 13;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(171, 160);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(128, 20);
            this.txt_city.TabIndex = 12;
            // 
            // txt_province
            // 
            this.txt_province.Location = new System.Drawing.Point(455, 52);
            this.txt_province.Name = "txt_province";
            this.txt_province.Size = new System.Drawing.Size(128, 20);
            this.txt_province.TabIndex = 11;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(455, 78);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(128, 20);
            this.txt_country.TabIndex = 10;
            // 
            // txt_postalcode
            // 
            this.txt_postalcode.Location = new System.Drawing.Point(455, 108);
            this.txt_postalcode.Name = "txt_postalcode";
            this.txt_postalcode.Size = new System.Drawing.Size(128, 20);
            this.txt_postalcode.TabIndex = 9;
            // 
            // txt_c_number
            // 
            this.txt_c_number.Location = new System.Drawing.Point(171, 56);
            this.txt_c_number.Name = "txt_c_number";
            this.txt_c_number.Size = new System.Drawing.Size(128, 20);
            this.txt_c_number.TabIndex = 8;
            // 
            // lbl_c_name
            // 
            this.lbl_c_name.AutoSize = true;
            this.lbl_c_name.Location = new System.Drawing.Point(75, 89);
            this.lbl_c_name.Name = "lbl_c_name";
            this.lbl_c_name.Size = new System.Drawing.Size(81, 13);
            this.lbl_c_name.TabIndex = 7;
            this.lbl_c_name.Text = "Complex Name:";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(75, 115);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(38, 13);
            this.lbl_street.TabIndex = 6;
            this.lbl_street.Text = "Street:";
            // 
            // lbl_suburb
            // 
            this.lbl_suburb.AutoSize = true;
            this.lbl_suburb.Location = new System.Drawing.Point(75, 141);
            this.lbl_suburb.Name = "lbl_suburb";
            this.lbl_suburb.Size = new System.Drawing.Size(44, 13);
            this.lbl_suburb.TabIndex = 5;
            this.lbl_suburb.Text = "Suburb:";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(75, 167);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(27, 13);
            this.lbl_city.TabIndex = 4;
            this.lbl_city.Text = "City:";
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Location = new System.Drawing.Point(357, 59);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(52, 13);
            this.lbl_province.TabIndex = 3;
            this.lbl_province.Text = "Province:";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(357, 89);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(46, 13);
            this.lbl_country.TabIndex = 2;
            this.lbl_country.Text = "Country:";
            // 
            // lbl_postalcode
            // 
            this.lbl_postalcode.AutoSize = true;
            this.lbl_postalcode.Location = new System.Drawing.Point(357, 115);
            this.lbl_postalcode.Name = "lbl_postalcode";
            this.lbl_postalcode.Size = new System.Drawing.Size(67, 13);
            this.lbl_postalcode.TabIndex = 1;
            this.lbl_postalcode.Text = "Postal Code:";
            // 
            // lbl_c_number
            // 
            this.lbl_c_number.AutoSize = true;
            this.lbl_c_number.Location = new System.Drawing.Point(75, 63);
            this.lbl_c_number.Name = "lbl_c_number";
            this.lbl_c_number.Size = new System.Drawing.Size(90, 13);
            this.lbl_c_number.TabIndex = 0;
            this.lbl_c_number.Text = "Complex Number:";
            // 
            // listaddress
            // 
            this.listaddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ad_id,
            this.ad_complexnuum,
            this.ad_complexname,
            this.ad_street,
            this.ad_sub,
            this.ad_city,
            this.ad_province,
            this.ad_country,
            this.ad_postcode});
            this.listaddress.HideSelection = false;
            this.listaddress.Location = new System.Drawing.Point(15, 213);
            this.listaddress.MultiSelect = false;
            this.listaddress.Name = "listaddress";
            this.listaddress.Size = new System.Drawing.Size(853, 164);
            this.listaddress.TabIndex = 4;
            this.listaddress.UseCompatibleStateImageBehavior = false;
            this.listaddress.View = System.Windows.Forms.View.Details;
            this.listaddress.SelectedIndexChanged += new System.EventHandler(this.listaddress_SelectedIndexChanged);
            // 
            // ad_id
            // 
            this.ad_id.Text = "ID";
            this.ad_id.Width = 31;
            // 
            // ad_complexnuum
            // 
            this.ad_complexnuum.Text = "Complex Number";
            this.ad_complexnuum.Width = 94;
            // 
            // ad_complexname
            // 
            this.ad_complexname.Text = "Complex Name";
            this.ad_complexname.Width = 106;
            // 
            // ad_street
            // 
            this.ad_street.Text = "Street";
            this.ad_street.Width = 115;
            // 
            // ad_sub
            // 
            this.ad_sub.Text = "Suburb";
            this.ad_sub.Width = 103;
            // 
            // ad_city
            // 
            this.ad_city.Text = "City";
            this.ad_city.Width = 87;
            // 
            // ad_province
            // 
            this.ad_province.Text = "Province";
            this.ad_province.Width = 104;
            // 
            // ad_country
            // 
            this.ad_country.Text = "Country";
            this.ad_country.Width = 129;
            // 
            // ad_postcode
            // 
            this.ad_postcode.Text = "Postal Code";
            this.ad_postcode.Width = 154;
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 389);
            this.ControlBox = false;
            this.Controls.Add(this.listaddress);
            this.Controls.Add(this.address_information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddress";
            this.ShowIcon = false;
            this.Text = "frmAddress";
            this.address_information.ResumeLayout(false);
            this.address_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox address_information;
        private System.Windows.Forms.Label lbl_c_number;
        private System.Windows.Forms.Label lbl_c_name;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_suburb;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_postalcode;
        private System.Windows.Forms.TextBox txt_c_number;
        private System.Windows.Forms.TextBox txt_c_name;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_province;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_postalcode;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView listaddress;
        private System.Windows.Forms.ColumnHeader ad_id;
        private System.Windows.Forms.ColumnHeader ad_complexnuum;
        private System.Windows.Forms.ColumnHeader ad_complexname;
        private System.Windows.Forms.ColumnHeader ad_street;
        private System.Windows.Forms.ColumnHeader ad_sub;
        private System.Windows.Forms.ColumnHeader ad_city;
        private System.Windows.Forms.ColumnHeader ad_province;
        private System.Windows.Forms.ColumnHeader ad_country;
        private System.Windows.Forms.ColumnHeader ad_postcode;
    }
}