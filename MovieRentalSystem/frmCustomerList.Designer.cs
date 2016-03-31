namespace MovieRentalSystem
{
    partial class frmCustomerList
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lstCustomerList = new System.Windows.Forms.ListView();
            this.gbxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.lblCityState = new System.Windows.Forms.Label();
            this.btnMovieInventory = new System.Windows.Forms.Button();
            this.gbxCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(662, 398);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 34);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lstCustomerList
            // 
            this.lstCustomerList.Location = new System.Drawing.Point(12, 12);
            this.lstCustomerList.Name = "lstCustomerList";
            this.lstCustomerList.Size = new System.Drawing.Size(392, 373);
            this.lstCustomerList.TabIndex = 13;
            this.lstCustomerList.UseCompatibleStateImageBehavior = false;
            // 
            // gbxCustomerInfo
            // 
            this.gbxCustomerInfo.Controls.Add(this.lblCustomerName);
            this.gbxCustomerInfo.Controls.Add(this.lblZipcode);
            this.gbxCustomerInfo.Controls.Add(this.txtName);
            this.gbxCustomerInfo.Controls.Add(this.btnAddCustomer);
            this.gbxCustomerInfo.Controls.Add(this.txtZipcode);
            this.gbxCustomerInfo.Controls.Add(this.txtAddress);
            this.gbxCustomerInfo.Controls.Add(this.lblDOB);
            this.gbxCustomerInfo.Controls.Add(this.lblAddress);
            this.gbxCustomerInfo.Controls.Add(this.txtDOB);
            this.gbxCustomerInfo.Controls.Add(this.txtCityState);
            this.gbxCustomerInfo.Controls.Add(this.lblCityState);
            this.gbxCustomerInfo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerInfo.Location = new System.Drawing.Point(453, 12);
            this.gbxCustomerInfo.Name = "gbxCustomerInfo";
            this.gbxCustomerInfo.Size = new System.Drawing.Size(274, 373);
            this.gbxCustomerInfo.TabIndex = 22;
            this.gbxCustomerInfo.TabStop = false;
            this.gbxCustomerInfo.Text = "Customer Information";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(24, 77);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(39, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Name";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.Location = new System.Drawing.Point(24, 183);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(63, 13);
            this.lblZipcode.TabIndex = 12;
            this.lblZipcode.Text = "Zipcode";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(84, 300);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 43);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(156, 175);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(100, 26);
            this.txtZipcode.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(24, 218);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(31, 13);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "DOB";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(24, 113);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Street Address";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(156, 210);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 26);
            this.txtDOB.TabIndex = 9;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(156, 140);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(100, 26);
            this.txtCityState.TabIndex = 7;
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityState.Location = new System.Drawing.Point(24, 148);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(95, 13);
            this.lblCityState.TabIndex = 8;
            this.lblCityState.Text = "City, State";
            // 
            // btnMovieInventory
            // 
            this.btnMovieInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieInventory.Location = new System.Drawing.Point(12, 398);
            this.btnMovieInventory.Name = "btnMovieInventory";
            this.btnMovieInventory.Size = new System.Drawing.Size(100, 34);
            this.btnMovieInventory.TabIndex = 23;
            this.btnMovieInventory.Text = "Go to Movie Inventory";
            this.btnMovieInventory.UseVisualStyleBackColor = true;
            this.btnMovieInventory.Click += new System.EventHandler(this.btnMovieInventory_Click);
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 444);
            this.Controls.Add(this.btnMovieInventory);
            this.Controls.Add(this.gbxCustomerInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lstCustomerList);
            this.Name = "frmCustomerList";
            this.Text = "Customer List";
            this.gbxCustomerInfo.ResumeLayout(false);
            this.gbxCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView lstCustomerList;
        private System.Windows.Forms.GroupBox gbxCustomerInfo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.Button btnMovieInventory;
    }
}