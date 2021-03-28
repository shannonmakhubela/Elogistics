namespace ELogistics
{
    partial class FrmStatus
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
            this.txt_driver_id = new System.Windows.Forms.TextBox();
            this.txt_datepicked = new System.Windows.Forms.DateTimePicker();
            this.txt_delivereddate = new System.Windows.Forms.DateTimePicker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_status_id = new System.Windows.Forms.TextBox();
            this.lbl_pickedup = new System.Windows.Forms.Label();
            this.lbl_driverid = new System.Windows.Forms.Label();
            this.lbl_delivered = new System.Windows.Forms.Label();
            this.lbl_status_id = new System.Windows.Forms.Label();
            this.liststatus = new System.Windows.Forms.ListView();
            this.s_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_driverid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_pickedup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_delivered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // address_information
            // 
            this.address_information.Controls.Add(this.txt_driver_id);
            this.address_information.Controls.Add(this.txt_datepicked);
            this.address_information.Controls.Add(this.txt_delivereddate);
            this.address_information.Controls.Add(this.btn_exit);
            this.address_information.Controls.Add(this.btn_read);
            this.address_information.Controls.Add(this.btn_update);
            this.address_information.Controls.Add(this.btn_delete);
            this.address_information.Controls.Add(this.btn_create);
            this.address_information.Controls.Add(this.txt_status_id);
            this.address_information.Controls.Add(this.lbl_pickedup);
            this.address_information.Controls.Add(this.lbl_driverid);
            this.address_information.Controls.Add(this.lbl_delivered);
            this.address_information.Controls.Add(this.lbl_status_id);
            this.address_information.Location = new System.Drawing.Point(12, 12);
            this.address_information.Name = "address_information";
            this.address_information.Size = new System.Drawing.Size(471, 120);
            this.address_information.TabIndex = 2;
            this.address_information.TabStop = false;
            this.address_information.Text = "Address information:";
            // 
            // txt_driver_id
            // 
            this.txt_driver_id.Location = new System.Drawing.Point(327, 15);
            this.txt_driver_id.Name = "txt_driver_id";
            this.txt_driver_id.Size = new System.Drawing.Size(128, 20);
            this.txt_driver_id.TabIndex = 24;
            // 
            // txt_datepicked
            // 
            this.txt_datepicked.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_datepicked.Location = new System.Drawing.Point(102, 46);
            this.txt_datepicked.Name = "txt_datepicked";
            this.txt_datepicked.Size = new System.Drawing.Size(128, 20);
            this.txt_datepicked.TabIndex = 23;
            // 
            // txt_delivereddate
            // 
            this.txt_delivereddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_delivereddate.Location = new System.Drawing.Point(327, 46);
            this.txt_delivereddate.Name = "txt_delivereddate";
            this.txt_delivereddate.Size = new System.Drawing.Size(128, 20);
            this.txt_delivereddate.TabIndex = 21;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(365, 84);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(89, 84);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 19;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(170, 84);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(269, 84);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(8, 84);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_status_id
            // 
            this.txt_status_id.Location = new System.Drawing.Point(102, 19);
            this.txt_status_id.Name = "txt_status_id";
            this.txt_status_id.Size = new System.Drawing.Size(128, 20);
            this.txt_status_id.TabIndex = 8;
            // 
            // lbl_pickedup
            // 
            this.lbl_pickedup.AutoSize = true;
            this.lbl_pickedup.Location = new System.Drawing.Point(6, 52);
            this.lbl_pickedup.Name = "lbl_pickedup";
            this.lbl_pickedup.Size = new System.Drawing.Size(58, 13);
            this.lbl_pickedup.TabIndex = 7;
            this.lbl_pickedup.Text = "Picked up:";
            // 
            // lbl_driverid
            // 
            this.lbl_driverid.AutoSize = true;
            this.lbl_driverid.Location = new System.Drawing.Point(266, 22);
            this.lbl_driverid.Name = "lbl_driverid";
            this.lbl_driverid.Size = new System.Drawing.Size(49, 13);
            this.lbl_driverid.TabIndex = 3;
            this.lbl_driverid.Text = "Driver id:";
            // 
            // lbl_delivered
            // 
            this.lbl_delivered.AutoSize = true;
            this.lbl_delivered.Location = new System.Drawing.Point(266, 52);
            this.lbl_delivered.Name = "lbl_delivered";
            this.lbl_delivered.Size = new System.Drawing.Size(55, 13);
            this.lbl_delivered.TabIndex = 2;
            this.lbl_delivered.Text = "Delivered:";
            // 
            // lbl_status_id
            // 
            this.lbl_status_id.AutoSize = true;
            this.lbl_status_id.Location = new System.Drawing.Point(6, 26);
            this.lbl_status_id.Name = "lbl_status_id";
            this.lbl_status_id.Size = new System.Drawing.Size(51, 13);
            this.lbl_status_id.TabIndex = 0;
            this.lbl_status_id.Text = "Status id:";
            // 
            // liststatus
            // 
            this.liststatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.s_id,
            this.status_id,
            this.s_driverid,
            this.s_pickedup,
            this.s_delivered});
            this.liststatus.HideSelection = false;
            this.liststatus.Location = new System.Drawing.Point(12, 138);
            this.liststatus.MultiSelect = false;
            this.liststatus.Name = "liststatus";
            this.liststatus.Size = new System.Drawing.Size(471, 185);
            this.liststatus.TabIndex = 4;
            this.liststatus.UseCompatibleStateImageBehavior = false;
            this.liststatus.View = System.Windows.Forms.View.Details;
            this.liststatus.SelectedIndexChanged += new System.EventHandler(this.liststatus_SelectedIndexChanged);
            // 
            // s_id
            // 
            this.s_id.Text = "ID";
            this.s_id.Width = 32;
            // 
            // status_id
            // 
            this.status_id.Text = "Status ID";
            this.status_id.Width = 89;
            // 
            // s_driverid
            // 
            this.s_driverid.Text = "Driver ID";
            this.s_driverid.Width = 76;
            // 
            // s_pickedup
            // 
            this.s_pickedup.Text = "Picked Up";
            this.s_pickedup.Width = 113;
            // 
            // s_delivered
            // 
            this.s_delivered.Text = "Delivered";
            this.s_delivered.Width = 70;
            // 
            // FrmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.ControlBox = false;
            this.Controls.Add(this.liststatus);
            this.Controls.Add(this.address_information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatus";
            this.ShowIcon = false;
            this.Text = "FrmStatus";
            this.address_information.ResumeLayout(false);
            this.address_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox address_information;
        private System.Windows.Forms.DateTimePicker txt_delivereddate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_status_id;
        private System.Windows.Forms.Label lbl_pickedup;
        private System.Windows.Forms.Label lbl_driverid;
        private System.Windows.Forms.Label lbl_delivered;
        private System.Windows.Forms.Label lbl_status_id;
        private System.Windows.Forms.DateTimePicker txt_datepicked;
        private System.Windows.Forms.TextBox txt_driver_id;
        private System.Windows.Forms.ListView liststatus;
        private System.Windows.Forms.ColumnHeader s_id;
        private System.Windows.Forms.ColumnHeader status_id;
        private System.Windows.Forms.ColumnHeader s_driverid;
        private System.Windows.Forms.ColumnHeader s_pickedup;
        private System.Windows.Forms.ColumnHeader s_delivered;
    }
}