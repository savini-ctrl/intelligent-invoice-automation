namespace ContosoLegacyFinance
{
    partial class InvoiceForm
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
            lblTitle = new Label();
            lblTitle2 = new Label();
            cmbSupplier = new ComboBox();
            lblWSupplier = new Label();
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            txtPoNumber = new Label();
            txtPONo = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            lblNetAmt = new Label();
            lblVatAmt = new Label();
            lblTotalAmt = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnValidate = new Button();
            btnPostInvoice = new Button();
            btnNewInvoice = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(169, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " CONTOSO FINANCE SYSTEM - INVOICE ENTRY";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Location = new Point(259, 61);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(93, 20);
            lblTitle2.TabIndex = 1;
            lblTitle2.Text = "Invoice Entry";
            lblTitle2.Click += lblTitle2_Click;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(308, 97);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(151, 28);
            cmbSupplier.TabIndex = 2;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // lblWSupplier
            // 
            lblWSupplier.AutoSize = true;
            lblWSupplier.Location = new Point(120, 100);
            lblWSupplier.Name = "lblWSupplier";
            lblWSupplier.Size = new Size(64, 20);
            lblWSupplier.TabIndex = 3;
            lblWSupplier.Text = "Supplier";
            lblWSupplier.Click += lblWSupplier_Click;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Location = new Point(123, 143);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(114, 20);
            lblInvoiceNo.TabIndex = 4;
            lblInvoiceNo.Text = "Invoice Number";
            lblInvoiceNo.Click += lblInvoiceNo_Click;
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Location = new Point(308, 143);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(151, 27);
            txtInvoiceNo.TabIndex = 5;
            // 
            // txtPoNumber
            // 
            txtPoNumber.AutoSize = true;
            txtPoNumber.Location = new Point(124, 180);
            txtPoNumber.Name = "txtPoNumber";
            txtPoNumber.Size = new Size(86, 20);
            txtPoNumber.TabIndex = 6;
            txtPoNumber.Text = "PO Number";
            // 
            // txtPONo
            // 
            txtPONo.Location = new Point(308, 192);
            txtPONo.Name = "txtPONo";
            txtPONo.Size = new Size(153, 27);
            txtPONo.TabIndex = 7;
            txtPONo.TextChanged += txtPONo_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(308, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(124, 231);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(92, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Invoice Date";
            // 
            // lblNetAmt
            // 
            lblNetAmt.AutoSize = true;
            lblNetAmt.Location = new Point(124, 276);
            lblNetAmt.Name = "lblNetAmt";
            lblNetAmt.Size = new Size(90, 20);
            lblNetAmt.TabIndex = 10;
            lblNetAmt.Text = "Net Amount";
            lblNetAmt.Click += label1_Click;
            // 
            // lblVatAmt
            // 
            lblVatAmt.AutoSize = true;
            lblVatAmt.Location = new Point(124, 313);
            lblVatAmt.Name = "lblVatAmt";
            lblVatAmt.Size = new Size(91, 20);
            lblVatAmt.TabIndex = 11;
            lblVatAmt.Text = "VAT Amount";
            // 
            // lblTotalAmt
            // 
            lblTotalAmt.AutoSize = true;
            lblTotalAmt.Location = new Point(124, 351);
            lblTotalAmt.Name = "lblTotalAmt";
            lblTotalAmt.Size = new Size(99, 20);
            lblTotalAmt.TabIndex = 12;
            lblTotalAmt.Text = "Total Amount";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(128, 384);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category";
            lblCategory.Click += label1_Click_1;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(301, 388);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 313);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(143, 436);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 18;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnPostInvoice
            // 
            btnPostInvoice.Location = new Point(296, 437);
            btnPostInvoice.Name = "btnPostInvoice";
            btnPostInvoice.Size = new Size(134, 29);
            btnPostInvoice.TabIndex = 19;
            btnPostInvoice.Text = "Post Invoice";
            btnPostInvoice.UseVisualStyleBackColor = true;
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.Location = new Point(197, 492);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.Size = new Size(143, 29);
            btnNewInvoice.TabIndex = 20;
            btnNewInvoice.Text = "New Invoice";
            btnNewInvoice.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 603);
            Controls.Add(btnNewInvoice);
            Controls.Add(btnPostInvoice);
            Controls.Add(btnValidate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblTotalAmt);
            Controls.Add(lblVatAmt);
            Controls.Add(lblNetAmt);
            Controls.Add(lblDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPONo);
            Controls.Add(txtPoNumber);
            Controls.Add(txtInvoiceNo);
            Controls.Add(lblInvoiceNo);
            Controls.Add(lblWSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblTitle2);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contoso Finance System - Invoice Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTitle2;
        private ComboBox cmbSupplier;
        private Label lblWSupplier;
        private Label lblInvoiceNo;
        private TextBox txtInvoiceNo;
        private Label txtPoNumber;
        private TextBox txtPONo;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private Label lblNetAmt;
        private Label lblVatAmt;
        private Label lblTotalAmt;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnValidate;
        private Button btnPostInvoice;
        private Button btnNewInvoice;
    }
}