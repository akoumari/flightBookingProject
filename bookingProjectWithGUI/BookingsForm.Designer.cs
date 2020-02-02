namespace bookingProjectWithGUI
{
    partial class BookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnSelectC = new System.Windows.Forms.Button();
            this.btnSelectF = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Cust = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Flight = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAndBookingDataSet = new bookingProjectWithGUI.CustAndBookingDataSet();
            this.tblFlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataSet = new bookingProjectWithGUI.FlightDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.tblBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.tbl_BookingsTableAdapter = new bookingProjectWithGUI.CustAndBookingDataSetTableAdapters.tbl_BookingsTableAdapter();
            this.tbl_CustomerTableAdapter = new bookingProjectWithGUI.CustAndBookingDataSetTableAdapters.tbl_CustomerTableAdapter();
            this.tbl_FlightsTableAdapter = new bookingProjectWithGUI.FlightDataSetTableAdapters.tbl_FlightsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.btnClr);
            this.panel1.Controls.Add(this.btnSelectC);
            this.panel1.Controls.Add(this.btnSelectF);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.txtCustId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFlNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv_Cust);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_Flight);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Location = new System.Drawing.Point(121, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 498);
            this.panel1.TabIndex = 25;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMsg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtMsg.ForeColor = System.Drawing.Color.Red;
            this.txtMsg.Location = new System.Drawing.Point(93, 294);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(0);
            this.txtMsg.MaximumSize = new System.Drawing.Size(180, 64);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(180, 64);
            this.txtMsg.TabIndex = 31;
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.White;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.Black;
            this.btnClr.Location = new System.Drawing.Point(183, 368);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(71, 35);
            this.btnClr.TabIndex = 30;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // btnSelectC
            // 
            this.btnSelectC.BackColor = System.Drawing.Color.White;
            this.btnSelectC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectC.ForeColor = System.Drawing.Color.Black;
            this.btnSelectC.Location = new System.Drawing.Point(290, 410);
            this.btnSelectC.Name = "btnSelectC";
            this.btnSelectC.Size = new System.Drawing.Size(73, 35);
            this.btnSelectC.TabIndex = 29;
            this.btnSelectC.Text = "Use ID";
            this.btnSelectC.UseVisualStyleBackColor = false;
            this.btnSelectC.Click += new System.EventHandler(this.BtnSelectC_Click);
            // 
            // btnSelectF
            // 
            this.btnSelectF.BackColor = System.Drawing.Color.White;
            this.btnSelectF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectF.ForeColor = System.Drawing.Color.Black;
            this.btnSelectF.Location = new System.Drawing.Point(290, 120);
            this.btnSelectF.Name = "btnSelectF";
            this.btnSelectF.Size = new System.Drawing.Size(73, 35);
            this.btnSelectF.TabIndex = 28;
            this.btnSelectF.Text = "Use ID";
            this.btnSelectF.UseVisualStyleBackColor = false;
            this.btnSelectF.Click += new System.EventHandler(this.BtnSelectF_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(264, 34);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // txtCustId
            // 
            this.txtCustId.BackColor = System.Drawing.Color.White;
            this.txtCustId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCustId.Enabled = false;
            this.txtCustId.Location = new System.Drawing.Point(139, 256);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(92, 26);
            this.txtCustId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customers List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(25, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Customer ID";
            // 
            // txtFlNum
            // 
            this.txtFlNum.BackColor = System.Drawing.Color.White;
            this.txtFlNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlNum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFlNum.Enabled = false;
            this.txtFlNum.Location = new System.Drawing.Point(139, 204);
            this.txtFlNum.Name = "txtFlNum";
            this.txtFlNum.ReadOnly = true;
            this.txtFlNum.Size = new System.Drawing.Size(92, 26);
            this.txtFlNum.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Flights List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Flight Number";
            // 
            // dgv_Cust
            // 
            this.dgv_Cust.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cust.Location = new System.Drawing.Point(369, 304);
            this.dgv_Cust.MultiSelect = false;
            this.dgv_Cust.Name = "dgv_Cust";
            this.dgv_Cust.ReadOnly = true;
            this.dgv_Cust.RowTemplate.Height = 28;
            this.dgv_Cust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cust.Size = new System.Drawing.Size(551, 180);
            this.dgv_Cust.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Make Booking";
            // 
            // dgv_Flight
            // 
            this.dgv_Flight.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Flight.Location = new System.Drawing.Point(369, 61);
            this.dgv_Flight.MultiSelect = false;
            this.dgv_Flight.Name = "dgv_Flight";
            this.dgv_Flight.ReadOnly = true;
            this.dgv_Flight.RowTemplate.Height = 28;
            this.dgv_Flight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Flight.Size = new System.Drawing.Size(551, 192);
            this.dgv_Flight.TabIndex = 19;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddBook.Location = new System.Drawing.Point(116, 368);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(61, 35);
            this.btnAddBook.TabIndex = 13;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.custAndBookingDataSet;
            // 
            // custAndBookingDataSet
            // 
            this.custAndBookingDataSet.DataSetName = "CustAndBookingDataSet";
            this.custAndBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 37);
            this.label6.TabIndex = 27;
            this.label6.Text = "Bookings List";
            // 
            // dgv_Book
            // 
            this.dgv_Book.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Book.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Location = new System.Drawing.Point(260, 560);
            this.dgv_Book.MultiSelect = false;
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.ReadOnly = true;
            this.dgv_Book.RowTemplate.Height = 28;
            this.dgv_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Book.Size = new System.Drawing.Size(647, 180);
            this.dgv_Book.TabIndex = 26;
            // 
            // tblBookingsBindingSource
            // 
            this.tblBookingsBindingSource.DataMember = "tbl_Bookings";
            this.tblBookingsBindingSource.DataSource = this.custAndBookingDataSet;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.SystemColors.Window;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1054, 687);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 53);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbl_BookingsTableAdapter
            // 
            this.tbl_BookingsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_FlightsTableAdapter
            // 
            this.tbl_FlightsTableAdapter.ClearBeforeFill = true;
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 752);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Book);
            this.MinimumSize = new System.Drawing.Size(1200, 808);
            this.Name = "BookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingsForm";
            this.Load += new System.EventHandler(this.BookingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Cust;
        private System.Windows.Forms.DataGridView dgv_Flight;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Book;
        private System.Windows.Forms.Button btnBack;
        private CustAndBookingDataSet custAndBookingDataSet;
        private System.Windows.Forms.BindingSource tblBookingsBindingSource;
        private CustAndBookingDataSetTableAdapters.tbl_BookingsTableAdapter tbl_BookingsTableAdapter;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private CustAndBookingDataSetTableAdapters.tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private FlightDataSet flightDataSet;
        private System.Windows.Forms.BindingSource tblFlightsBindingSource;
        private FlightDataSetTableAdapters.tbl_FlightsTableAdapter tbl_FlightsTableAdapter;
        private System.Windows.Forms.Button btnSelectC;
        private System.Windows.Forms.Button btnSelectF;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TextBox txtMsg;
    }
}