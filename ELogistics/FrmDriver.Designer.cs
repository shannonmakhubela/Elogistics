namespace ELogistics
{
    partial class FrmDriver
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
            this.no_check = new System.Windows.Forms.CheckBox();
            this.yes_check = new System.Windows.Forms.CheckBox();
            this.ltype = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_license_Type = new System.Windows.Forms.Label();
            this.lbl_owner = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.listdriver = new System.Windows.Forms.ListView();
            this.box_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box_fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box_ltype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box_owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // address_information
            // 
            this.address_information.Controls.Add(this.no_check);
            this.address_information.Controls.Add(this.yes_check);
            this.address_information.Controls.Add(this.ltype);
            this.address_information.Controls.Add(this.btn_exit);
            this.address_information.Controls.Add(this.btn_read);
            this.address_information.Controls.Add(this.btn_update);
            this.address_information.Controls.Add(this.btn_delete);
            this.address_information.Controls.Add(this.btn_create);
            this.address_information.Controls.Add(this.txt_fullname);
            this.address_information.Controls.Add(this.lbl_license_Type);
            this.address_information.Controls.Add(this.lbl_owner);
            this.address_information.Controls.Add(this.lbl_fullname);
            this.address_information.Location = new System.Drawing.Point(12, 12);
            this.address_information.Name = "address_information";
            this.address_information.Size = new System.Drawing.Size(421, 161);
            this.address_information.TabIndex = 2;
            this.address_information.TabStop = false;
            this.address_information.Text = "Address information:";
            // 
            // no_check
            // 
            this.no_check.AutoSize = true;
            this.no_check.Location = new System.Drawing.Point(186, 91);
            this.no_check.Name = "no_check";
            this.no_check.Size = new System.Drawing.Size(40, 17);
            this.no_check.TabIndex = 24;
            this.no_check.Text = "No";
            this.no_check.UseVisualStyleBackColor = true;
            this.no_check.CheckedChanged += new System.EventHandler(this.no_check_CheckedChanged);
            // 
            // yes_check
            // 
            this.yes_check.AutoSize = true;
            this.yes_check.Location = new System.Drawing.Point(102, 92);
            this.yes_check.Name = "yes_check";
            this.yes_check.Size = new System.Drawing.Size(44, 17);
            this.yes_check.TabIndex = 23;
            this.yes_check.Text = "Yes";
            this.yes_check.UseVisualStyleBackColor = true;
            this.yes_check.CheckedChanged += new System.EventHandler(this.yes_check_CheckedChanged);
            // 
            // ltype
            // 
            this.ltype.FormattingEnabled = true;
            this.ltype.Location = new System.Drawing.Point(102, 49);
            this.ltype.Name = "ltype";
            this.ltype.Size = new System.Drawing.Size(128, 21);
            this.ltype.TabIndex = 22;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(325, 120);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(87, 120);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 19;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(168, 120);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(244, 120);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(6, 122);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(102, 19);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(128, 20);
            this.txt_fullname.TabIndex = 8;
            // 
            // lbl_license_Type
            // 
            this.lbl_license_Type.AutoSize = true;
            this.lbl_license_Type.Location = new System.Drawing.Point(6, 52);
            this.lbl_license_Type.Name = "lbl_license_Type";
            this.lbl_license_Type.Size = new System.Drawing.Size(74, 13);
            this.lbl_license_Type.TabIndex = 7;
            this.lbl_license_Type.Text = "License Type:";
            // 
            // lbl_owner
            // 
            this.lbl_owner.AutoSize = true;
            this.lbl_owner.Location = new System.Drawing.Point(6, 92);
            this.lbl_owner.Name = "lbl_owner";
            this.lbl_owner.Size = new System.Drawing.Size(41, 13);
            this.lbl_owner.TabIndex = 1;
            this.lbl_owner.Text = "Owner:";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Location = new System.Drawing.Point(6, 26);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(57, 13);
            this.lbl_fullname.TabIndex = 0;
            this.lbl_fullname.Text = "Full Name:";
            // 
            // listdriver
            // 
            this.listdriver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.box_id,
            this.box_fullname,
            this.box_ltype,
            this.box_owner});
            this.listdriver.HideSelection = false;
            this.listdriver.Location = new System.Drawing.Point(12, 192);
            this.listdriver.MultiSelect = false;
            this.listdriver.Name = "listdriver";
            this.listdriver.Size = new System.Drawing.Size(421, 138);
            this.listdriver.TabIndex = 3;
            this.listdriver.UseCompatibleStateImageBehavior = false;
            this.listdriver.View = System.Windows.Forms.View.Details;
            this.listdriver.SelectedIndexChanged += new System.EventHandler(this.listdriver_SelectedIndexChanged);
            // 
            // box_id
            // 
            this.box_id.Text = "ID";
            // 
            // box_fullname
            // 
            this.box_fullname.Text = "FullName";
            // 
            // box_ltype
            // 
            this.box_ltype.Text = "Licence Type";
            // 
            // box_owner
            // 
            this.box_owner.Text = "Owner";
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 377);
            this.ControlBox = false;
            this.Controls.Add(this.listdriver);
            this.Controls.Add(this.address_information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDriver";
            this.Text = "FrmDriver";
            this.address_information.ResumeLayout(false);
            this.address_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox address_information;
        private System.Windows.Forms.ComboBox ltype;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_license_Type;
        private System.Windows.Forms.Label lbl_owner;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.CheckBox yes_check;
        private System.Windows.Forms.CheckBox no_check;
        private System.Windows.Forms.ListView listdriver;
        private System.Windows.Forms.ColumnHeader box_id;
        private System.Windows.Forms.ColumnHeader box_fullname;
        private System.Windows.Forms.ColumnHeader box_ltype;
        private System.Windows.Forms.ColumnHeader box_owner;
    }
}