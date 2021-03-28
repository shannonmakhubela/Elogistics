namespace ELogistics
{
    partial class Ctu
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
            this.address = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.freight = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.statuses = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(73, 59);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(175, 71);
            this.address.TabIndex = 0;
            this.address.Text = "Manage Addresses:";
            this.address.UseVisualStyleBackColor = true;
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(306, 59);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(175, 71);
            this.customers.TabIndex = 1;
            this.customers.Text = "Manage Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // freight
            // 
            this.freight.Location = new System.Drawing.Point(548, 59);
            this.freight.Name = "freight";
            this.freight.Size = new System.Drawing.Size(175, 71);
            this.freight.TabIndex = 2;
            this.freight.Text = "Manage Freight:";
            this.freight.UseVisualStyleBackColor = true;
            this.freight.Click += new System.EventHandler(this.freight_Click);
            // 
            // drivers
            // 
            this.drivers.Location = new System.Drawing.Point(73, 168);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(175, 71);
            this.drivers.TabIndex = 3;
            this.drivers.Text = "Manage Drivers:";
            this.drivers.UseVisualStyleBackColor = true;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // statuses
            // 
            this.statuses.Location = new System.Drawing.Point(306, 168);
            this.statuses.Name = "statuses";
            this.statuses.Size = new System.Drawing.Size(175, 71);
            this.statuses.TabIndex = 4;
            this.statuses.Text = "Manage Statuses:";
            this.statuses.UseVisualStyleBackColor = true;
            this.statuses.Click += new System.EventHandler(this.statuses_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(548, 168);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(175, 71);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Ctu
            // 
            this.ClientSize = new System.Drawing.Size(768, 290);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statuses);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.freight);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.address);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ctu";
            this.ShowIcon = false;
            this.Text = "Ctu Logistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button address;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button freight;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.Button statuses;
        private System.Windows.Forms.Button exit;
    }
}

