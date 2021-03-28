namespace ELogistics
{
    partial class frmFreight
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
            this.components = new System.ComponentModel.Container();
            this.address_information = new System.Windows.Forms.GroupBox();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLogisticsDataSet = new ELogistics.ELogisticsDataSet();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.txt_origin_address = new System.Windows.Forms.TextBox();
            this.txt_c_number = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_c_number = new System.Windows.Forms.Label();
            this.statusTableAdapter = new ELogistics.ELogisticsDataSetTableAdapters.StatusTableAdapter();
            this.listf = new System.Windows.Forms.ListView();
            this.f_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_cn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_l = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_st = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_oa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLogisticsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // address_information
            // 
            this.address_information.Controls.Add(this.txt_status);
            this.address_information.Controls.Add(this.txt_date);
            this.address_information.Controls.Add(this.btn_exit);
            this.address_information.Controls.Add(this.btn_read);
            this.address_information.Controls.Add(this.btn_update);
            this.address_information.Controls.Add(this.btn_delete);
            this.address_information.Controls.Add(this.btn_create);
            this.address_information.Controls.Add(this.txt_height);
            this.address_information.Controls.Add(this.txt_length);
            this.address_information.Controls.Add(this.txt_weight);
            this.address_information.Controls.Add(this.txt_destination);
            this.address_information.Controls.Add(this.txt_origin_address);
            this.address_information.Controls.Add(this.txt_c_number);
            this.address_information.Controls.Add(this.lbl_height);
            this.address_information.Controls.Add(this.lbl_length);
            this.address_information.Controls.Add(this.lbl_weight);
            this.address_information.Controls.Add(this.lbl_destination);
            this.address_information.Controls.Add(this.lbl_status);
            this.address_information.Controls.Add(this.lbl_address);
            this.address_information.Controls.Add(this.lbl_date);
            this.address_information.Controls.Add(this.lbl_c_number);
            this.address_information.Location = new System.Drawing.Point(12, 12);
            this.address_information.Name = "address_information";
            this.address_information.Size = new System.Drawing.Size(789, 167);
            this.address_information.TabIndex = 1;
            this.address_information.TabStop = false;
            this.address_information.Text = "Address information:";
            // 
            // txt_status
            // 
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Location = new System.Drawing.Point(386, 14);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(128, 21);
            this.txt_status.TabIndex = 22;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.eLogisticsDataSet;
            // 
            // eLogisticsDataSet
            // 
            this.eLogisticsDataSet.DataSetName = "ELogisticsDataSet";
            this.eLogisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(386, 72);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(128, 20);
            this.txt_date.TabIndex = 21;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(705, 121);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(467, 121);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 19;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(548, 121);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(624, 121);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(386, 120);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(102, 45);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(128, 20);
            this.txt_height.TabIndex = 15;
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(102, 71);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(128, 20);
            this.txt_length.TabIndex = 14;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(102, 97);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(128, 20);
            this.txt_weight.TabIndex = 13;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(102, 123);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(128, 20);
            this.txt_destination.TabIndex = 12;
            // 
            // txt_origin_address
            // 
            this.txt_origin_address.Location = new System.Drawing.Point(386, 41);
            this.txt_origin_address.Name = "txt_origin_address";
            this.txt_origin_address.Size = new System.Drawing.Size(128, 20);
            this.txt_origin_address.TabIndex = 10;
            // 
            // txt_c_number
            // 
            this.txt_c_number.Location = new System.Drawing.Point(102, 19);
            this.txt_c_number.Name = "txt_c_number";
            this.txt_c_number.Size = new System.Drawing.Size(128, 20);
            this.txt_c_number.TabIndex = 8;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(6, 52);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(41, 13);
            this.lbl_height.TabIndex = 7;
            this.lbl_height.Text = "Height:";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(6, 78);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(43, 13);
            this.lbl_length.TabIndex = 6;
            this.lbl_length.Text = "Lenght:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(6, 104);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(44, 13);
            this.lbl_weight.TabIndex = 5;
            this.lbl_weight.Text = "Weight:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Location = new System.Drawing.Point(6, 130);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(63, 13);
            this.lbl_destination.TabIndex = 4;
            this.lbl_destination.Text = "Destination:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(288, 22);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(40, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(288, 52);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(78, 13);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Origin Address:";
            this.lbl_address.Click += new System.EventHandler(this.lbl_country_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(288, 78);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(33, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_c_number
            // 
            this.lbl_c_number.AutoSize = true;
            this.lbl_c_number.Location = new System.Drawing.Point(6, 26);
            this.lbl_c_number.Name = "lbl_c_number";
            this.lbl_c_number.Size = new System.Drawing.Size(87, 13);
            this.lbl_c_number.TabIndex = 0;
            this.lbl_c_number.Text = "Contact Number:";
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // listf
            // 
            this.listf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.f_id,
            this.f_cn,
            this.f_h,
            this.f_l,
            this.l_w,
            this.f_d,
            this.f_st,
            this.f_oa,
            this.f_date});
            this.listf.HideSelection = false;
            this.listf.Location = new System.Drawing.Point(12, 201);
            this.listf.MultiSelect = false;
            this.listf.Name = "listf";
            this.listf.Size = new System.Drawing.Size(780, 184);
            this.listf.TabIndex = 4;
            this.listf.UseCompatibleStateImageBehavior = false;
            this.listf.View = System.Windows.Forms.View.Details;
            this.listf.SelectedIndexChanged += new System.EventHandler(this.listf_SelectedIndexChanged);
            // 
            // f_id
            // 
            this.f_id.Text = "ID";
            this.f_id.Width = 36;
            // 
            // f_cn
            // 
            this.f_cn.Text = "Contact Number";
            this.f_cn.Width = 117;
            // 
            // f_h
            // 
            this.f_h.Text = "Height";
            // 
            // f_l
            // 
            this.f_l.Text = "Length";
            // 
            // l_w
            // 
            this.l_w.Text = "weight";
            // 
            // f_d
            // 
            this.f_d.Text = "Destination";
            this.f_d.Width = 85;
            // 
            // f_st
            // 
            this.f_st.Text = "Status";
            this.f_st.Width = 90;
            // 
            // f_oa
            // 
            this.f_oa.Text = "Origin Address";
            this.f_oa.Width = 123;
            // 
            // f_date
            // 
            this.f_date.Text = "Date";
            // 
            // frmFreight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 397);
            this.ControlBox = false;
            this.Controls.Add(this.listf);
            this.Controls.Add(this.address_information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFreight";
            this.ShowIcon = false;
            this.Text = "frmFreight";
            this.Load += new System.EventHandler(this.frmFreight_Load);
            this.address_information.ResumeLayout(false);
            this.address_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLogisticsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox address_information;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.TextBox txt_origin_address;
        private System.Windows.Forms.TextBox txt_c_number;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_c_number;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.ComboBox txt_status;
        private ELogisticsDataSet eLogisticsDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private ELogisticsDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.ListView listf;
        private System.Windows.Forms.ColumnHeader f_id;
        private System.Windows.Forms.ColumnHeader f_cn;
        private System.Windows.Forms.ColumnHeader f_h;
        private System.Windows.Forms.ColumnHeader f_l;
        private System.Windows.Forms.ColumnHeader l_w;
        private System.Windows.Forms.ColumnHeader f_d;
        private System.Windows.Forms.ColumnHeader f_st;
        private System.Windows.Forms.ColumnHeader f_oa;
        private System.Windows.Forms.ColumnHeader f_date;
    }
}