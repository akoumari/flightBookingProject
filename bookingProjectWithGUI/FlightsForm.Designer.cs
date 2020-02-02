namespace bookingProjectWithGUI
{
    partial class FlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.dgv_FlightList = new System.Windows.Forms.DataGridView();
            this.tblFlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet = new bookingProjectWithGUI.FlightDataSet();
            this.dgv_fDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlightNum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbl_FlightsTableAdapter = new bookingProjectWithGUI.FlightDataSetTableAdapters.tbl_FlightsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FlightList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_FlightList
            // 
            this.dgv_FlightList.AllowUserToAddRows = false;
            this.dgv_FlightList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_FlightList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_FlightList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_FlightList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FlightList.Location = new System.Drawing.Point(34, 56);
            this.dgv_FlightList.MultiSelect = false;
            this.dgv_FlightList.Name = "dgv_FlightList";
            this.dgv_FlightList.ReadOnly = true;
            this.dgv_FlightList.RowTemplate.Height = 28;
            this.dgv_FlightList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FlightList.Size = new System.Drawing.Size(542, 192);
            this.dgv_FlightList.TabIndex = 0;
            this.dgv_FlightList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_FlightList_CellContentClick);
            // 
            // tblFlightsBindingSource
            // 
            this.tblFlightsBindingSource.DataMember = "tbl_Flights";
            this.tblFlightsBindingSource.DataSource = this.flightDataSet;
            // 
            // flightDataSet
            // 
            this.flightDataSet.DataSetName = "FlightDataSet";
            this.flightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_fDetails
            // 
            this.dgv_fDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_fDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_fDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_fDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fDetails.Location = new System.Drawing.Point(34, 318);
            this.dgv_fDetails.MultiSelect = false;
            this.dgv_fDetails.Name = "dgv_fDetails";
            this.dgv_fDetails.ReadOnly = true;
            this.dgv_fDetails.RowTemplate.Height = 28;
            this.dgv_fDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fDetails.Size = new System.Drawing.Size(542, 180);
            this.dgv_fDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flights List";
            // 
            // btnViewFlight
            // 
            this.btnViewFlight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewFlight.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlight.ForeColor = System.Drawing.Color.Black;
            this.btnViewFlight.Location = new System.Drawing.Point(582, 90);
            this.btnViewFlight.Name = "btnViewFlight";
            this.btnViewFlight.Size = new System.Drawing.Size(112, 53);
            this.btnViewFlight.TabIndex = 15;
            this.btnViewFlight.Text = "View Details";
            this.btnViewFlight.UseVisualStyleBackColor = false;
            this.btnViewFlight.Click += new System.EventHandler(this.BtnViewFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteFlight.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFlight.Location = new System.Drawing.Point(582, 184);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(112, 53);
            this.btnDeleteFlight.TabIndex = 16;
            this.btnDeleteFlight.Text = "Delete Selected";
            this.btnDeleteFlight.UseVisualStyleBackColor = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.BtnDeleteFlight_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Flight Details";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.txtDest);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOrigin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaxCap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFlightNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Location = new System.Drawing.Point(780, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 456);
            this.panel1.TabIndex = 18;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMsg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtMsg.ForeColor = System.Drawing.Color.Red;
            this.txtMsg.Location = new System.Drawing.Point(132, 326);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(0);
            this.txtMsg.MaximumSize = new System.Drawing.Size(164, 65);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(164, 65);
            this.txtMsg.TabIndex = 32;
            // 
            // txtDest
            // 
            this.txtDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDest.Location = new System.Drawing.Point(132, 287);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(211, 26);
            this.txtDest.TabIndex = 26;
            this.txtDest.Leave += new System.EventHandler(this.TxtDest_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Destination";
            // 
            // txtOrigin
            // 
            this.txtOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOrigin.Location = new System.Drawing.Point(132, 234);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(211, 26);
            this.txtOrigin.TabIndex = 24;
            this.txtOrigin.Leave += new System.EventHandler(this.TxtOrigin_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Origin";
            // 
            // txtMaxCap
            // 
            this.txtMaxCap.HidePromptOnLeave = true;
            this.txtMaxCap.Location = new System.Drawing.Point(132, 180);
            this.txtMaxCap.Mask = "0000";
            this.txtMaxCap.Name = "txtMaxCap";
            this.txtMaxCap.Size = new System.Drawing.Size(100, 26);
            this.txtMaxCap.SkipLiterals = false;
            this.txtMaxCap.TabIndex = 22;
            this.txtMaxCap.Click += new System.EventHandler(this.TxtMaxCap_Click);
            this.txtMaxCap.DoubleClick += new System.EventHandler(this.TxtMaxCap_DoubleClick);
            this.txtMaxCap.Enter += new System.EventHandler(this.TxtMaxCap_Enter);
            this.txtMaxCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaxCap_KeyPress);
            this.txtMaxCap.Leave += new System.EventHandler(this.TxtMaxCap_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(18, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max Capacity";
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.HidePromptOnLeave = true;
            this.txtFlightNum.Location = new System.Drawing.Point(132, 128);
            this.txtFlightNum.Mask = "000000";
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(100, 26);
            this.txtFlightNum.TabIndex = 20;
            this.txtFlightNum.Click += new System.EventHandler(this.TxtFlightNum_Click);
            this.txtFlightNum.DoubleClick += new System.EventHandler(this.TxtFlightNum_DoubleClick);
            this.txtFlightNum.Enter += new System.EventHandler(this.TxtFlightNum_Enter);
            this.txtFlightNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFlightNum_KeyPress);
            this.txtFlightNum.Leave += new System.EventHandler(this.TxtFlightNum_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Flight Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add Flight";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(264, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.White;
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.Black;
            this.btnAddFlight.Location = new System.Drawing.Point(132, 406);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(112, 35);
            this.btnAddFlight.TabIndex = 13;
            this.btnAddFlight.Text = "Add";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.BtnAddFlight_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1054, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 53);
            this.button3.TabIndex = 19;
            this.button3.Text = "Back to Main";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbl_FlightsTableAdapter
            // 
            this.tbl_FlightsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(582, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove Passenger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnViewFlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_fDetails);
            this.Controls.Add(this.dgv_FlightList);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightsForm";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FlightList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FlightList;
        private System.Windows.Forms.DataGridView dgv_fDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtMaxCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFlightNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button3;
        private FlightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource tblFlightsBindingSource;
        private FlightDataSetTableAdapters.tbl_FlightsTableAdapter tbl_FlightsTableAdapter;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button button1;
    }
}