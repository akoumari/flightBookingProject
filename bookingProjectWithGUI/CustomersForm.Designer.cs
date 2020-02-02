namespace bookingProjectWithGUI
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Cust = new System.Windows.Forms.DataGridView();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAndBookingDataSet = new bookingProjectWithGUI.CustAndBookingDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbl_CustomerTableAdapter = new bookingProjectWithGUI.CustAndBookingDataSetTableAdapters.tbl_CustomerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndBookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Location = new System.Drawing.Point(778, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 456);
            this.panel1.TabIndex = 25;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMsg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtMsg.ForeColor = System.Drawing.Color.Red;
            this.txtMsg.Location = new System.Drawing.Point(124, 291);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(0);
            this.txtMsg.MaximumSize = new System.Drawing.Size(180, 86);
            this.txtMsg.MinimumSize = new System.Drawing.Size(180, 60);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(180, 86);
            this.txtMsg.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(264, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 242);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 26);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.Leave += new System.EventHandler(this.TxtPhone_Leave);
            this.txtPhone.MouseHover += new System.EventHandler(this.TxtPhone_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(18, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone Number";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(150, 186);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(132, 26);
            this.txtLName.TabIndex = 22;
            this.txtLName.Leave += new System.EventHandler(this.TxtLName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(150, 128);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(132, 26);
            this.txtFName.TabIndex = 20;
            this.txtFName.Leave += new System.EventHandler(this.TxtFName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add Customer";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.White;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.Black;
            this.btnAddCust.Location = new System.Drawing.Point(160, 394);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(112, 35);
            this.btnAddCust.TabIndex = 13;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.BtnAddCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCust.Location = new System.Drawing.Point(580, 263);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(112, 53);
            this.btnDeleteCust.TabIndex = 23;
            this.btnDeleteCust.Text = "Delete Selected";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.BtnDeleteCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customers List";
            // 
            // dgv_Cust
            // 
            this.dgv_Cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Cust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Cust.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cust.Location = new System.Drawing.Point(32, 62);
            this.dgv_Cust.MultiSelect = false;
            this.dgv_Cust.Name = "dgv_Cust";
            this.dgv_Cust.ReadOnly = true;
            this.dgv_Cust.RowTemplate.Height = 28;
            this.dgv_Cust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cust.Size = new System.Drawing.Size(542, 500);
            this.dgv_Cust.TabIndex = 19;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Window;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1054, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 53);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Cust);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndBookingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Cust;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private CustAndBookingDataSet custAndBookingDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private CustAndBookingDataSetTableAdapters.tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}