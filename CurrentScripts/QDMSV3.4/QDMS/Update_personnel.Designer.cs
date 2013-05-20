namespace WindowsFormsApplication1
{
    partial class Update_personnel
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
            this.Heading_update = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.Update_Password_label = new System.Windows.Forms.Label();
            this.New_Password = new System.Windows.Forms.Label();
            this.UserID_input_for_password_change = new System.Windows.Forms.TextBox();
            this.New_password_input = new System.Windows.Forms.TextBox();
            this.Submit_for_password = new System.Windows.Forms.Button();
            this.Change_address = new System.Windows.Forms.Label();
            this.UserID_address_label = new System.Windows.Forms.Label();
            this.User_ID_input_address_Change = new System.Windows.Forms.TextBox();
            this.Address_update_input = new System.Windows.Forms.TextBox();
            this.Address_upate_label = new System.Windows.Forms.Label();
            this.PostCode_label = new System.Windows.Forms.Label();
            this.PostCode_input_update = new System.Windows.Forms.TextBox();
            this.Update_city_input = new System.Windows.Forms.TextBox();
            this.City_update_label = new System.Windows.Forms.Label();
            this.Submit_updated_address = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading_update
            // 
            this.Heading_update.AutoSize = true;
            this.Heading_update.Location = new System.Drawing.Point(13, 13);
            this.Heading_update.Name = "Heading_update";
            this.Heading_update.Size = new System.Drawing.Size(100, 13);
            this.Heading_update.TabIndex = 0;
            this.Heading_update.Text = "Updating Personnel";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(38, 75);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(43, 13);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "UserID:";
            // 
            // Update_Password_label
            // 
            this.Update_Password_label.AutoSize = true;
            this.Update_Password_label.Location = new System.Drawing.Point(38, 47);
            this.Update_Password_label.Name = "Update_Password_label";
            this.Update_Password_label.Size = new System.Drawing.Size(91, 13);
            this.Update_Password_label.TabIndex = 2;
            this.Update_Password_label.Text = "Update Password";
            this.Update_Password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // New_Password
            // 
            this.New_Password.AutoSize = true;
            this.New_Password.Location = new System.Drawing.Point(38, 103);
            this.New_Password.Name = "New_Password";
            this.New_Password.Size = new System.Drawing.Size(78, 13);
            this.New_Password.TabIndex = 3;
            this.New_Password.Text = "New Password";
            // 
            // UserID_input_for_password_change
            // 
            this.UserID_input_for_password_change.Location = new System.Drawing.Point(132, 68);
            this.UserID_input_for_password_change.MaxLength = 9;
            this.UserID_input_for_password_change.Name = "UserID_input_for_password_change";
            this.UserID_input_for_password_change.Size = new System.Drawing.Size(100, 20);
            this.UserID_input_for_password_change.TabIndex = 4;
            // 
            // New_password_input
            // 
            this.New_password_input.Location = new System.Drawing.Point(132, 103);
            this.New_password_input.MaxLength = 40;
            this.New_password_input.Name = "New_password_input";
            this.New_password_input.Size = new System.Drawing.Size(100, 20);
            this.New_password_input.TabIndex = 5;
            // 
            // Submit_for_password
            // 
            this.Submit_for_password.Location = new System.Drawing.Point(132, 141);
            this.Submit_for_password.Name = "Submit_for_password";
            this.Submit_for_password.Size = new System.Drawing.Size(100, 23);
            this.Submit_for_password.TabIndex = 6;
            this.Submit_for_password.Text = "Submit password change";
            this.Submit_for_password.UseVisualStyleBackColor = true;
            // 
            // Change_address
            // 
            this.Change_address.AutoSize = true;
            this.Change_address.Location = new System.Drawing.Point(38, 170);
            this.Change_address.Name = "Change_address";
            this.Change_address.Size = new System.Drawing.Size(85, 13);
            this.Change_address.TabIndex = 7;
            this.Change_address.Text = "Change Address";
            // 
            // UserID_address_label
            // 
            this.UserID_address_label.AutoSize = true;
            this.UserID_address_label.Location = new System.Drawing.Point(38, 202);
            this.UserID_address_label.Name = "UserID_address_label";
            this.UserID_address_label.Size = new System.Drawing.Size(46, 13);
            this.UserID_address_label.TabIndex = 8;
            this.UserID_address_label.Text = "UserID: ";
            // 
            // User_ID_input_address_Change
            // 
            this.User_ID_input_address_Change.Location = new System.Drawing.Point(132, 202);
            this.User_ID_input_address_Change.MaxLength = 9;
            this.User_ID_input_address_Change.Name = "User_ID_input_address_Change";
            this.User_ID_input_address_Change.Size = new System.Drawing.Size(100, 20);
            this.User_ID_input_address_Change.TabIndex = 9;
            // 
            // Address_update_input
            // 
            this.Address_update_input.Location = new System.Drawing.Point(132, 239);
            this.Address_update_input.Name = "Address_update_input";
            this.Address_update_input.Size = new System.Drawing.Size(100, 20);
            this.Address_update_input.TabIndex = 10;
            // 
            // Address_upate_label
            // 
            this.Address_upate_label.AutoSize = true;
            this.Address_upate_label.Location = new System.Drawing.Point(38, 242);
            this.Address_upate_label.Name = "Address_upate_label";
            this.Address_upate_label.Size = new System.Drawing.Size(48, 13);
            this.Address_upate_label.TabIndex = 11;
            this.Address_upate_label.Text = "Address:";
            // 
            // PostCode_label
            // 
            this.PostCode_label.AutoSize = true;
            this.PostCode_label.Location = new System.Drawing.Point(38, 279);
            this.PostCode_label.Name = "PostCode_label";
            this.PostCode_label.Size = new System.Drawing.Size(53, 13);
            this.PostCode_label.TabIndex = 12;
            this.PostCode_label.Text = "PostCode";
            // 
            // PostCode_input_update
            // 
            this.PostCode_input_update.Location = new System.Drawing.Point(132, 276);
            this.PostCode_input_update.Name = "PostCode_input_update";
            this.PostCode_input_update.Size = new System.Drawing.Size(100, 20);
            this.PostCode_input_update.TabIndex = 13;
            // 
            // Update_city_input
            // 
            this.Update_city_input.Location = new System.Drawing.Point(132, 313);
            this.Update_city_input.Name = "Update_city_input";
            this.Update_city_input.Size = new System.Drawing.Size(100, 20);
            this.Update_city_input.TabIndex = 14;
            // 
            // City_update_label
            // 
            this.City_update_label.AutoSize = true;
            this.City_update_label.Location = new System.Drawing.Point(38, 316);
            this.City_update_label.Name = "City_update_label";
            this.City_update_label.Size = new System.Drawing.Size(74, 13);
            this.City_update_label.TabIndex = 15;
            this.City_update_label.Text = "Upadate City: ";
            // 
            // Submit_updated_address
            // 
            this.Submit_updated_address.Location = new System.Drawing.Point(132, 340);
            this.Submit_updated_address.Name = "Submit_updated_address";
            this.Submit_updated_address.Size = new System.Drawing.Size(100, 23);
            this.Submit_updated_address.TabIndex = 16;
            this.Submit_updated_address.Text = "Submit  address";
            this.Submit_updated_address.UseVisualStyleBackColor = true;
            // 
            // Update_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.Submit_updated_address);
            this.Controls.Add(this.City_update_label);
            this.Controls.Add(this.Update_city_input);
            this.Controls.Add(this.PostCode_input_update);
            this.Controls.Add(this.PostCode_label);
            this.Controls.Add(this.Address_upate_label);
            this.Controls.Add(this.Address_update_input);
            this.Controls.Add(this.User_ID_input_address_Change);
            this.Controls.Add(this.UserID_address_label);
            this.Controls.Add(this.Change_address);
            this.Controls.Add(this.Submit_for_password);
            this.Controls.Add(this.New_password_input);
            this.Controls.Add(this.UserID_input_for_password_change);
            this.Controls.Add(this.New_Password);
            this.Controls.Add(this.Update_Password_label);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Heading_update);
            this.Name = "Update_personnel";
            this.Text = "Update Personnel";
            this.Load += new System.EventHandler(this.Update_personnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading_update;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label Update_Password_label;
        private System.Windows.Forms.Label New_Password;
        private System.Windows.Forms.TextBox UserID_input_for_password_change;
        private System.Windows.Forms.TextBox New_password_input;
        private System.Windows.Forms.Button Submit_for_password;
        private System.Windows.Forms.Label Change_address;
        private System.Windows.Forms.Label UserID_address_label;
        private System.Windows.Forms.TextBox User_ID_input_address_Change;
        private System.Windows.Forms.TextBox Address_update_input;
        private System.Windows.Forms.Label Address_upate_label;
        private System.Windows.Forms.Label PostCode_label;
        private System.Windows.Forms.TextBox PostCode_input_update;
        private System.Windows.Forms.TextBox Update_city_input;
        private System.Windows.Forms.Label City_update_label;
        private System.Windows.Forms.Button Submit_updated_address;
    }
}