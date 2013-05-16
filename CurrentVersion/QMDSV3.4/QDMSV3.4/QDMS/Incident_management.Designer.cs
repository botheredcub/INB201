namespace WindowsFormsApplication1
{
    partial class Incident_management
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
            this.Incident_Type_label = new System.Windows.Forms.Label();
            this.Incident_Address_label = new System.Windows.Forms.Label();
            this.notes_label = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.Incident_date_label = new System.Windows.Forms.Label();
            this.Incident_address = new System.Windows.Forms.TextBox();
            this.Incident_date = new System.Windows.Forms.DateTimePicker();
            this.Region_list = new System.Windows.Forms.ComboBox();
            this.Incident_type_box = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TextBox();
            this.Current_status_label = new System.Windows.Forms.Label();
            this.Current_status_list = new System.Windows.Forms.ComboBox();
            this.Introduction = new System.Windows.Forms.Label();
            this.Recently_added_incidents_heading = new System.Windows.Forms.Label();
            this.Update_incident_heading = new System.Windows.Forms.Label();
            this.Incident_ID_update_label = new System.Windows.Forms.Label();
            this.Current_status_update_label = new System.Windows.Forms.Label();
            this.Incident_id_update = new System.Windows.Forms.ComboBox();
            this.incident_id_search = new System.Windows.Forms.TextBox();
            this.Submit1 = new System.Windows.Forms.Button();
            this.Update_date_picker = new System.Windows.Forms.DateTimePicker();
            this.updatedatelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Current_warning_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Incident_Type_label
            // 
            this.Incident_Type_label.AutoSize = true;
            this.Incident_Type_label.Location = new System.Drawing.Point(154, 89);
            this.Incident_Type_label.Name = "Incident_Type_label";
            this.Incident_Type_label.Size = new System.Drawing.Size(75, 13);
            this.Incident_Type_label.TabIndex = 1;
            this.Incident_Type_label.Text = "Incident Type:";
            // 
            // Incident_Address_label
            // 
            this.Incident_Address_label.AutoSize = true;
            this.Incident_Address_label.Location = new System.Drawing.Point(154, 116);
            this.Incident_Address_label.Name = "Incident_Address_label";
            this.Incident_Address_label.Size = new System.Drawing.Size(89, 13);
            this.Incident_Address_label.TabIndex = 2;
            this.Incident_Address_label.Text = "Incident Address:";
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Location = new System.Drawing.Point(151, 262);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(87, 13);
            this.notes_label.TabIndex = 3;
            this.notes_label.Text = "Additional Notes:";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(151, 209);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(27, 13);
            this.City_label.TabIndex = 4;
            this.City_label.Text = "City:";
            // 
            // Incident_date_label
            // 
            this.Incident_date_label.AutoSize = true;
            this.Incident_date_label.Location = new System.Drawing.Point(151, 235);
            this.Incident_date_label.Name = "Incident_date_label";
            this.Incident_date_label.Size = new System.Drawing.Size(64, 13);
            this.Incident_date_label.TabIndex = 6;
            this.Incident_date_label.Text = "Event Date:";
            // 
            // Incident_address
            // 
            this.Incident_address.Location = new System.Drawing.Point(249, 113);
            this.Incident_address.MaxLength = 50;
            this.Incident_address.Name = "Incident_address";
            this.Incident_address.Size = new System.Drawing.Size(200, 20);
            this.Incident_address.TabIndex = 7;
            this.Incident_address.TextChanged += new System.EventHandler(this.Incident_address_TextChanged);
            // 
            // Incident_date
            // 
            this.Incident_date.Location = new System.Drawing.Point(251, 228);
            this.Incident_date.Name = "Incident_date";
            this.Incident_date.Size = new System.Drawing.Size(200, 20);
            this.Incident_date.TabIndex = 9;
            this.Incident_date.ValueChanged += new System.EventHandler(this.Incident_date_ValueChanged);
            // 
            // Region_list
            // 
            this.Region_list.FormattingEnabled = true;
            this.Region_list.Location = new System.Drawing.Point(250, 201);
            this.Region_list.Name = "Region_list";
            this.Region_list.Size = new System.Drawing.Size(121, 21);
            this.Region_list.TabIndex = 10;
            // 
            // Incident_type_box
            // 
            this.Incident_type_box.FormattingEnabled = true;
            this.Incident_type_box.Location = new System.Drawing.Point(250, 89);
            this.Incident_type_box.Name = "Incident_type_box";
            this.Incident_type_box.Size = new System.Drawing.Size(121, 21);
            this.Incident_type_box.TabIndex = 11;
            this.Incident_type_box.SelectedIndexChanged += new System.EventHandler(this.Incident_type_box_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(375, 334);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(249, 262);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(199, 58);
            this.Notes.TabIndex = 13;
            // 
            // Current_status_label
            // 
            this.Current_status_label.AutoSize = true;
            this.Current_status_label.Location = new System.Drawing.Point(154, 147);
            this.Current_status_label.Name = "Current_status_label";
            this.Current_status_label.Size = new System.Drawing.Size(75, 13);
            this.Current_status_label.TabIndex = 14;
            this.Current_status_label.Text = "Currrent status";
            // 
            // Current_status_list
            // 
            this.Current_status_list.FormattingEnabled = true;
            this.Current_status_list.Location = new System.Drawing.Point(250, 139);
            this.Current_status_list.Name = "Current_status_list";
            this.Current_status_list.Size = new System.Drawing.Size(121, 21);
            this.Current_status_list.TabIndex = 15;
            // 
            // Introduction
            // 
            this.Introduction.AutoSize = true;
            this.Introduction.Location = new System.Drawing.Point(12, 25);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(122, 13);
            this.Introduction.TabIndex = 16;
            this.Introduction.Text = "To input a new Incident ";
            // 
            // Recently_added_incidents_heading
            // 
            this.Recently_added_incidents_heading.AutoSize = true;
            this.Recently_added_incidents_heading.Location = new System.Drawing.Point(487, 25);
            this.Recently_added_incidents_heading.Name = "Recently_added_incidents_heading";
            this.Recently_added_incidents_heading.Size = new System.Drawing.Size(128, 13);
            this.Recently_added_incidents_heading.TabIndex = 17;
            this.Recently_added_incidents_heading.Text = "Recently added Incidents";
            // 
            // Update_incident_heading
            // 
            this.Update_incident_heading.AutoSize = true;
            this.Update_incident_heading.Location = new System.Drawing.Point(487, 228);
            this.Update_incident_heading.Name = "Update_incident_heading";
            this.Update_incident_heading.Size = new System.Drawing.Size(88, 13);
            this.Update_incident_heading.TabIndex = 18;
            this.Update_incident_heading.Text = "Update Incidents";
            // 
            // Incident_ID_update_label
            // 
            this.Incident_ID_update_label.AutoSize = true;
            this.Incident_ID_update_label.Location = new System.Drawing.Point(487, 262);
            this.Incident_ID_update_label.Name = "Incident_ID_update_label";
            this.Incident_ID_update_label.Size = new System.Drawing.Size(59, 13);
            this.Incident_ID_update_label.TabIndex = 19;
            this.Incident_ID_update_label.Text = "Incident ID";
            // 
            // Current_status_update_label
            // 
            this.Current_status_update_label.AutoSize = true;
            this.Current_status_update_label.Location = new System.Drawing.Point(487, 292);
            this.Current_status_update_label.Name = "Current_status_update_label";
            this.Current_status_update_label.Size = new System.Drawing.Size(78, 13);
            this.Current_status_update_label.TabIndex = 20;
            this.Current_status_update_label.Text = "Currrent_status";
            // 
            // Incident_id_update
            // 
            this.Incident_id_update.FormattingEnabled = true;
            this.Incident_id_update.Location = new System.Drawing.Point(565, 284);
            this.Incident_id_update.Name = "Incident_id_update";
            this.Incident_id_update.Size = new System.Drawing.Size(121, 21);
            this.Incident_id_update.TabIndex = 21;
            // 
            // incident_id_search
            // 
            this.incident_id_search.Location = new System.Drawing.Point(565, 255);
            this.incident_id_search.Name = "incident_id_search";
            this.incident_id_search.Size = new System.Drawing.Size(121, 20);
            this.incident_id_search.TabIndex = 22;
            // 
            // Submit1
            // 
            this.Submit1.Location = new System.Drawing.Point(701, 347);
            this.Submit1.Name = "Submit1";
            this.Submit1.Size = new System.Drawing.Size(75, 23);
            this.Submit1.TabIndex = 23;
            this.Submit1.Text = "Submit";
            this.Submit1.UseVisualStyleBackColor = true;
            this.Submit1.Click += new System.EventHandler(this.Submit1_Click);
            // 
            // Update_date_picker
            // 
            this.Update_date_picker.Location = new System.Drawing.Point(565, 311);
            this.Update_date_picker.Name = "Update_date_picker";
            this.Update_date_picker.Size = new System.Drawing.Size(200, 20);
            this.Update_date_picker.TabIndex = 24;
            // 
            // updatedatelabel
            // 
            this.updatedatelabel.AutoSize = true;
            this.updatedatelabel.Location = new System.Drawing.Point(487, 317);
            this.updatedatelabel.Name = "updatedatelabel";
            this.updatedatelabel.Size = new System.Drawing.Size(71, 13);
            this.updatedatelabel.TabIndex = 25;
            this.updatedatelabel.Text = "DateUpdated";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // Current_warning_label
            // 
            this.Current_warning_label.AutoSize = true;
            this.Current_warning_label.Location = new System.Drawing.Point(151, 177);
            this.Current_warning_label.Name = "Current_warning_label";
            this.Current_warning_label.Size = new System.Drawing.Size(92, 13);
            this.Current_warning_label.TabIndex = 28;
            this.Current_warning_label.Text = "Currrent Warnings";
            // 
            // Incident_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 526);
            this.Controls.Add(this.Current_warning_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.updatedatelabel);
            this.Controls.Add(this.Update_date_picker);
            this.Controls.Add(this.Submit1);
            this.Controls.Add(this.incident_id_search);
            this.Controls.Add(this.Incident_id_update);
            this.Controls.Add(this.Current_status_update_label);
            this.Controls.Add(this.Incident_ID_update_label);
            this.Controls.Add(this.Update_incident_heading);
            this.Controls.Add(this.Recently_added_incidents_heading);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.Current_status_list);
            this.Controls.Add(this.Current_status_label);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Incident_type_box);
            this.Controls.Add(this.Region_list);
            this.Controls.Add(this.Incident_date);
            this.Controls.Add(this.Incident_address);
            this.Controls.Add(this.Incident_date_label);
            this.Controls.Add(this.City_label);
            this.Controls.Add(this.notes_label);
            this.Controls.Add(this.Incident_Address_label);
            this.Controls.Add(this.Incident_Type_label);
            this.Name = "Incident_management";
            this.Text = "Incident Management ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Incident_Type_label;
        private System.Windows.Forms.Label Incident_Address_label;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label Incident_date_label;
        private System.Windows.Forms.TextBox Incident_address;
        private System.Windows.Forms.DateTimePicker Incident_date;
        private System.Windows.Forms.ComboBox Region_list;
        private System.Windows.Forms.ComboBox Incident_type_box;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label Current_status_label;
        private System.Windows.Forms.ComboBox Current_status_list;
        private System.Windows.Forms.Label Introduction;
        private System.Windows.Forms.Label Recently_added_incidents_heading;
        private System.Windows.Forms.Label Update_incident_heading;
        private System.Windows.Forms.Label Incident_ID_update_label;
        private System.Windows.Forms.Label Current_status_update_label;
        private System.Windows.Forms.ComboBox Incident_id_update;
        private System.Windows.Forms.TextBox incident_id_search;
        private System.Windows.Forms.Button Submit1;
        private System.Windows.Forms.DateTimePicker Update_date_picker;
        private System.Windows.Forms.Label updatedatelabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Current_warning_label;
    }
}