namespace ELogistics
{
    partial class frm_Customer_Management
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
            this.gb_customer = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_contactnumber = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_contactNumber = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.listcustomer = new System.Windows.Forms.ListView();
            this.c_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_customer
            // 
            this.gb_customer.Controls.Add(this.btn_exit);
            this.gb_customer.Controls.Add(this.btn_read);
            this.gb_customer.Controls.Add(this.btn_update);
            this.gb_customer.Controls.Add(this.btn_delete);
            this.gb_customer.Controls.Add(this.btn_create);
            this.gb_customer.Controls.Add(this.txt_contactnumber);
            this.gb_customer.Controls.Add(this.txt_email);
            this.gb_customer.Controls.Add(this.txt_fullname);
            this.gb_customer.Controls.Add(this.lbl_contactNumber);
            this.gb_customer.Controls.Add(this.lbl_email);
            this.gb_customer.Controls.Add(this.lbl_fullname);
            this.gb_customer.Location = new System.Drawing.Point(12, 12);
            this.gb_customer.Name = "gb_customer";
            this.gb_customer.Size = new System.Drawing.Size(704, 105);
            this.gb_customer.TabIndex = 1;
            this.gb_customer.TabStop = false;
            this.gb_customer.Text = "Customer:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(583, 74);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(345, 74);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 19;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(426, 74);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(502, 74);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(264, 74);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_contactnumber
            // 
            this.txt_contactnumber.Location = new System.Drawing.Point(105, 45);
            this.txt_contactnumber.Name = "txt_contactnumber";
            this.txt_contactnumber.Size = new System.Drawing.Size(128, 20);
            this.txt_contactnumber.TabIndex = 15;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(105, 71);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(128, 20);
            this.txt_email.TabIndex = 14;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(105, 19);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(128, 20);
            this.txt_fullname.TabIndex = 8;
            // 
            // lbl_contactNumber
            // 
            this.lbl_contactNumber.AutoSize = true;
            this.lbl_contactNumber.Location = new System.Drawing.Point(9, 52);
            this.lbl_contactNumber.Name = "lbl_contactNumber";
            this.lbl_contactNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_contactNumber.TabIndex = 7;
            this.lbl_contactNumber.Text = "ContactNumber:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(9, 74);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Location = new System.Drawing.Point(9, 26);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(52, 13);
            this.lbl_fullname.TabIndex = 0;
            this.lbl_fullname.Text = "Fullname:";
            // 
            // listcustomer
            // 
            this.listcustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_id,
            this.c_fullname,
            this.c_contact,
            this.c_email});
            this.listcustomer.HideSelection = false;
            this.listcustomer.Location = new System.Drawing.Point(11, 123);
            this.listcustomer.MultiSelect = false;
            this.listcustomer.Name = "listcustomer";
            this.listcustomer.Size = new System.Drawing.Size(701, 145);
            this.listcustomer.TabIndex = 4;
            this.listcustomer.UseCompatibleStateImageBehavior = false;
            this.listcustomer.View = System.Windows.Forms.View.Details;
            this.listcustomer.SelectedIndexChanged += new System.EventHandler(this.listdriver_SelectedIndexChanged);
            // 
            // c_id
            // 
            this.c_id.Text = "ID";
            this.c_id.Width = 37;
            // 
            // c_fullname
            // 
            this.c_fullname.Text = "FullName";
            this.c_fullname.Width = 218;
            // 
            // c_contact
            // 
            this.c_contact.Text = "Contact Number";
            this.c_contact.Width = 208;
            // 
            // c_email
            // 
            this.c_email.Text = "Email";
            this.c_email.Width = 319;
            // 
            // frm_Customer_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 267);
            this.ControlBox = false;
            this.Controls.Add(this.listcustomer);
            this.Controls.Add(this.gb_customer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Management";
            this.ShowIcon = false;
            this.Text = "Customer Management:";
            this.gb_customer.ResumeLayout(false);
            this.gb_customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_customer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_contactnumber;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_contactNumber;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.ListView listcustomer;
        private System.Windows.Forms.ColumnHeader c_id;
        private System.Windows.Forms.ColumnHeader c_fullname;
        private System.Windows.Forms.ColumnHeader c_contact;
        private System.Windows.Forms.ColumnHeader c_email;
    }
}