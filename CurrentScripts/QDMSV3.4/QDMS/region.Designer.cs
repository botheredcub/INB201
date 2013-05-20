namespace WindowsFormsApplication1
{
    partial class region
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.regiontitle = new System.Windows.Forms.Label();
            this.regionNamelabel = new System.Windows.Forms.Label();
            this.locationNamelabel = new System.Windows.Forms.Label();
            this.selectRegion = new System.Windows.Forms.ComboBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.zoomIn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.regionDetailpanel = new System.Windows.Forms.Panel();
            this.warningsalertsPanel = new System.Windows.Forms.SplitContainer();
            this.warningTextbox = new System.Windows.Forms.RichTextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.alertTextbox = new System.Windows.Forms.RichTextBox();
            this.alertLabel = new System.Windows.Forms.Label();
            this.reginfoPanel = new System.Windows.Forms.Panel();
            this.regionText = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.Label();
            this.threatText = new System.Windows.Forms.Label();
            this.threatLabel = new System.Windows.Forms.Label();
            this.regionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.regionSearchpanel = new System.Windows.Forms.Panel();
            this.mapPanel.SuspendLayout();
            this.regionDetailpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningsalertsPanel)).BeginInit();
            this.warningsalertsPanel.Panel1.SuspendLayout();
            this.warningsalertsPanel.Panel2.SuspendLayout();
            this.warningsalertsPanel.SuspendLayout();
            this.reginfoPanel.SuspendLayout();
            this.regionLayout.SuspendLayout();
            this.regionSearchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(641, 362);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 10D;
            // 
            // regiontitle
            // 
            this.regiontitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regiontitle.AutoSize = true;
            this.regiontitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiontitle.Location = new System.Drawing.Point(19, 29);
            this.regiontitle.Name = "regiontitle";
            this.regiontitle.Size = new System.Drawing.Size(215, 26);
            this.regiontitle.TabIndex = 3;
            this.regiontitle.Text = "Queensland Regions";
            // 
            // regionNamelabel
            // 
            this.regionNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionNamelabel.AutoSize = true;
            this.regionNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionNamelabel.Location = new System.Drawing.Point(20, 59);
            this.regionNamelabel.Name = "regionNamelabel";
            this.regionNamelabel.Size = new System.Drawing.Size(64, 20);
            this.regionNamelabel.TabIndex = 4;
            this.regionNamelabel.Text = "Region:";
            // 
            // locationNamelabel
            // 
            this.locationNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationNamelabel.AutoSize = true;
            this.locationNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationNamelabel.Location = new System.Drawing.Point(21, 79);
            this.locationNamelabel.Name = "locationNamelabel";
            this.locationNamelabel.Size = new System.Drawing.Size(66, 17);
            this.locationNamelabel.TabIndex = 5;
            this.locationNamelabel.Text = "Location:";
            // 
            // selectRegion
            // 
            this.selectRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRegion.FormattingEnabled = true;
            this.selectRegion.Location = new System.Drawing.Point(113, 48);
            this.selectRegion.Name = "selectRegion";
            this.selectRegion.Size = new System.Drawing.Size(121, 21);
            this.selectRegion.TabIndex = 6;
            this.selectRegion.SelectedIndexChanged += new System.EventHandler(this.selectRegion_SelectedIndexChanged);
            // 
            // Statuslabel
            // 
            this.Statuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.Location = new System.Drawing.Point(21, 96);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(52, 17);
            this.Statuslabel.TabIndex = 8;
            this.Statuslabel.Text = "Status:";
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusText.Location = new System.Drawing.Point(90, 96);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(57, 25);
            this.statusText.TabIndex = 9;
            this.statusText.Text = "Nothing";
            // 
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.gmap);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(247, 161);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(641, 362);
            this.mapPanel.TabIndex = 10;
            // 
            // zoomIn
            // 
            this.zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomIn.Location = new System.Drawing.Point(417, 93);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(75, 23);
            this.zoomIn.TabIndex = 11;
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(498, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Zoom Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // regionDetailpanel
            // 
            this.regionDetailpanel.Controls.Add(this.warningsalertsPanel);
            this.regionDetailpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regionDetailpanel.Location = new System.Drawing.Point(3, 161);
            this.regionDetailpanel.Name = "regionDetailpanel";
            this.regionDetailpanel.Size = new System.Drawing.Size(238, 362);
            this.regionDetailpanel.TabIndex = 11;
            // 
            // warningsalertsPanel
            // 
            this.warningsalertsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningsalertsPanel.Location = new System.Drawing.Point(0, 0);
            this.warningsalertsPanel.Name = "warningsalertsPanel";
            this.warningsalertsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // warningsalertsPanel.Panel1
            // 
            this.warningsalertsPanel.Panel1.Controls.Add(this.warningTextbox);
            this.warningsalertsPanel.Panel1.Controls.Add(this.warningLabel);
            // 
            // warningsalertsPanel.Panel2
            // 
            this.warningsalertsPanel.Panel2.Controls.Add(this.alertTextbox);
            this.warningsalertsPanel.Panel2.Controls.Add(this.alertLabel);
            this.warningsalertsPanel.Size = new System.Drawing.Size(238, 362);
            this.warningsalertsPanel.SplitterDistance = 162;
            this.warningsalertsPanel.TabIndex = 0;
            // 
            // warningTextbox
            // 
            this.warningTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningTextbox.Location = new System.Drawing.Point(3, 29);
            this.warningTextbox.Name = "warningTextbox";
            this.warningTextbox.ReadOnly = true;
            this.warningTextbox.Size = new System.Drawing.Size(231, 130);
            this.warningTextbox.TabIndex = 1;
            this.warningTextbox.Text = "";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(9, 9);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(72, 17);
            this.warningLabel.TabIndex = 0;
            this.warningLabel.Text = "Warnings:";
            // 
            // alertTextbox
            // 
            this.alertTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alertTextbox.Location = new System.Drawing.Point(3, 30);
            this.alertTextbox.Name = "alertTextbox";
            this.alertTextbox.ReadOnly = true;
            this.alertTextbox.Size = new System.Drawing.Size(231, 163);
            this.alertTextbox.TabIndex = 1;
            this.alertTextbox.Text = "";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.Location = new System.Drawing.Point(9, 10);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(44, 17);
            this.alertLabel.TabIndex = 0;
            this.alertLabel.Text = "Alerts";
            // 
            // reginfoPanel
            // 
            this.reginfoPanel.Controls.Add(this.regionText);
            this.reginfoPanel.Controls.Add(this.locationText);
            this.reginfoPanel.Controls.Add(this.threatText);
            this.reginfoPanel.Controls.Add(this.threatLabel);
            this.reginfoPanel.Controls.Add(this.regiontitle);
            this.reginfoPanel.Controls.Add(this.regionNamelabel);
            this.reginfoPanel.Controls.Add(this.locationNamelabel);
            this.reginfoPanel.Controls.Add(this.statusText);
            this.reginfoPanel.Controls.Add(this.Statuslabel);
            this.reginfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reginfoPanel.Location = new System.Drawing.Point(3, 3);
            this.reginfoPanel.Name = "reginfoPanel";
            this.reginfoPanel.Size = new System.Drawing.Size(238, 152);
            this.reginfoPanel.TabIndex = 12;
            // 
            // regionText
            // 
            this.regionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionText.AutoSize = true;
            this.regionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionText.Location = new System.Drawing.Point(89, 59);
            this.regionText.Name = "regionText";
            this.regionText.Size = new System.Drawing.Size(60, 20);
            this.regionText.TabIndex = 16;
            this.regionText.Text = "Region";
            // 
            // locationText
            // 
            this.locationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationText.AutoSize = true;
            this.locationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(90, 79);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(62, 17);
            this.locationText.TabIndex = 15;
            this.locationText.Text = "Location";
            // 
            // threatText
            // 
            this.threatText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threatText.AutoSize = true;
            this.threatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threatText.Location = new System.Drawing.Point(90, 113);
            this.threatText.Name = "threatText";
            this.threatText.Size = new System.Drawing.Size(79, 17);
            this.threatText.TabIndex = 14;
            this.threatText.Text = "No Threats";
            // 
            // threatLabel
            // 
            this.threatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threatLabel.AutoSize = true;
            this.threatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threatLabel.Location = new System.Drawing.Point(21, 113);
            this.threatLabel.Name = "threatLabel";
            this.threatLabel.Size = new System.Drawing.Size(54, 17);
            this.threatLabel.TabIndex = 13;
            this.threatLabel.Text = "Threat:";
            // 
            // regionLayout
            // 
            this.regionLayout.ColumnCount = 2;
            this.regionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.42927F));
            this.regionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.57072F));
            this.regionLayout.Controls.Add(this.reginfoPanel, 0, 0);
            this.regionLayout.Controls.Add(this.mapPanel, 1, 1);
            this.regionLayout.Controls.Add(this.regionDetailpanel, 0, 1);
            this.regionLayout.Controls.Add(this.regionSearchpanel, 1, 0);
            this.regionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regionLayout.Location = new System.Drawing.Point(0, 0);
            this.regionLayout.Name = "regionLayout";
            this.regionLayout.RowCount = 2;
            this.regionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.22814F));
            this.regionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.77187F));
            this.regionLayout.Size = new System.Drawing.Size(891, 526);
            this.regionLayout.TabIndex = 13;
            // 
            // regionSearchpanel
            // 
            this.regionSearchpanel.Controls.Add(this.zoomIn);
            this.regionSearchpanel.Controls.Add(this.selectRegion);
            this.regionSearchpanel.Controls.Add(this.button3);
            this.regionSearchpanel.Location = new System.Drawing.Point(247, 3);
            this.regionSearchpanel.Name = "regionSearchpanel";
            this.regionSearchpanel.Size = new System.Drawing.Size(585, 121);
            this.regionSearchpanel.TabIndex = 13;
            // 
            // region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 526);
            this.ControlBox = false;
            this.Controls.Add(this.regionLayout);
            this.Name = "region";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Region Information";
            this.Load += new System.EventHandler(this.region_Load);
            this.mapPanel.ResumeLayout(false);
            this.regionDetailpanel.ResumeLayout(false);
            this.warningsalertsPanel.Panel1.ResumeLayout(false);
            this.warningsalertsPanel.Panel1.PerformLayout();
            this.warningsalertsPanel.Panel2.ResumeLayout(false);
            this.warningsalertsPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningsalertsPanel)).EndInit();
            this.warningsalertsPanel.ResumeLayout(false);
            this.reginfoPanel.ResumeLayout(false);
            this.reginfoPanel.PerformLayout();
            this.regionLayout.ResumeLayout(false);
            this.regionSearchpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label regiontitle;
        private System.Windows.Forms.Label regionNamelabel;
        private System.Windows.Forms.Label locationNamelabel;
        private System.Windows.Forms.ComboBox selectRegion;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel regionDetailpanel;
        private System.Windows.Forms.Panel reginfoPanel;
        private System.Windows.Forms.Label regionText;
        private System.Windows.Forms.Label locationText;
        private System.Windows.Forms.Label threatText;
        private System.Windows.Forms.Label threatLabel;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.TableLayoutPanel regionLayout;
        private System.Windows.Forms.Panel regionSearchpanel;
        private System.Windows.Forms.SplitContainer warningsalertsPanel;
        private System.Windows.Forms.RichTextBox warningTextbox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.RichTextBox alertTextbox;
        private System.Windows.Forms.Label alertLabel;
    }
}