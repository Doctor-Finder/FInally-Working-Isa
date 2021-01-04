namespace Payment_form
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaymentMethodPicture = new System.Windows.Forms.PictureBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ElectronicWalletLabel = new System.Windows.Forms.Label();
            this.ElectronicWalletPicture = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DebitCardLabel = new System.Windows.Forms.Label();
            this.DebitCardPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CreditCardPicture = new System.Windows.Forms.PictureBox();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.CreditCardHolderLabel = new System.Windows.Forms.Label();
            this.CreditCardExpiryLabel = new System.Windows.Forms.Label();
            this.CreditCVVLabel = new System.Windows.Forms.Label();
            this.CreditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardHoldeTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardPanel = new System.Windows.Forms.Panel();
            this.CreditCVVTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardExpiryYearTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardExpiryMonthTextBox = new System.Windows.Forms.TextBox();
            this.DebitCardPanel = new System.Windows.Forms.Panel();
            this.DebitCardNumberLabel = new System.Windows.Forms.Label();
            this.DebitCardHolderLabel = new System.Windows.Forms.Label();
            this.DebitCardExpiryLabel = new System.Windows.Forms.Label();
            this.DebitCVVLabel = new System.Windows.Forms.Label();
            this.DebitCardHoldeTextBox = new System.Windows.Forms.TextBox();
            this.DebitCardExpiryMonthTextBox = new System.Windows.Forms.TextBox();
            this.DebitCardExpiryYearTextBox = new System.Windows.Forms.TextBox();
            this.DebitCVVTextBox = new System.Windows.Forms.TextBox();
            this.DebitCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicCardNumberLabel = new System.Windows.Forms.Label();
            this.ElectronicCardHolderLabel = new System.Windows.Forms.Label();
            this.ElectronicCardExpiryLabel = new System.Windows.Forms.Label();
            this.ElectronicCardCVVLabel = new System.Windows.Forms.Label();
            this.ElectronicCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicCardHolderTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicCardExpiryMonthTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicCardExpityYearTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicCardCVVTextBox = new System.Windows.Forms.TextBox();
            this.ElectronicWalletPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentMethodPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectronicWalletPicture)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebitCardPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditCardPicture)).BeginInit();
            this.CreditCardPanel.SuspendLayout();
            this.DebitCardPanel.SuspendLayout();
            this.ElectronicWalletPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.PaymentMethodPicture);
            this.panel1.Controls.Add(this.PaymentMethodLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 125);
            this.panel1.TabIndex = 0;
            // 
            // PaymentMethodPicture
            // 
            this.PaymentMethodPicture.Image = global::Payment_form.Properties.Resources.payment_method;
            this.PaymentMethodPicture.Location = new System.Drawing.Point(354, 45);
            this.PaymentMethodPicture.Name = "PaymentMethodPicture";
            this.PaymentMethodPicture.Size = new System.Drawing.Size(184, 77);
            this.PaymentMethodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentMethodPicture.TabIndex = 1;
            this.PaymentMethodPicture.TabStop = false;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(314, 0);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(252, 36);
            this.PaymentMethodLabel.TabIndex = 0;
            this.PaymentMethodLabel.Text = "Payment Method";
            this.PaymentMethodLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 452);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ElectronicWalletLabel);
            this.panel5.Controls.Add(this.ElectronicWalletPicture);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 152);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // ElectronicWalletLabel
            // 
            this.ElectronicWalletLabel.AutoSize = true;
            this.ElectronicWalletLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ElectronicWalletLabel.Location = new System.Drawing.Point(20, 98);
            this.ElectronicWalletLabel.Name = "ElectronicWalletLabel";
            this.ElectronicWalletLabel.Size = new System.Drawing.Size(109, 17);
            this.ElectronicWalletLabel.TabIndex = 1;
            this.ElectronicWalletLabel.Text = "Electronic wallet";
            this.ElectronicWalletLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ElectronicWalletPicture
            // 
            this.ElectronicWalletPicture.Image = global::Payment_form.Properties.Resources.phone;
            this.ElectronicWalletPicture.Location = new System.Drawing.Point(23, 6);
            this.ElectronicWalletPicture.Name = "ElectronicWalletPicture";
            this.ElectronicWalletPicture.Size = new System.Drawing.Size(100, 50);
            this.ElectronicWalletPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ElectronicWalletPicture.TabIndex = 0;
            this.ElectronicWalletPicture.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DebitCardLabel);
            this.panel4.Controls.Add(this.DebitCardPicture);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 150);
            this.panel4.TabIndex = 2;
            // 
            // DebitCardLabel
            // 
            this.DebitCardLabel.AutoSize = true;
            this.DebitCardLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DebitCardLabel.Location = new System.Drawing.Point(20, 96);
            this.DebitCardLabel.Name = "DebitCardLabel";
            this.DebitCardLabel.Size = new System.Drawing.Size(75, 17);
            this.DebitCardLabel.TabIndex = 1;
            this.DebitCardLabel.Text = "Debit Card";
            // 
            // DebitCardPicture
            // 
            this.DebitCardPicture.Image = global::Payment_form.Properties.Resources.credit_card__1_;
            this.DebitCardPicture.Location = new System.Drawing.Point(23, 6);
            this.DebitCardPicture.Name = "DebitCardPicture";
            this.DebitCardPicture.Size = new System.Drawing.Size(100, 50);
            this.DebitCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DebitCardPicture.TabIndex = 0;
            this.DebitCardPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CreditCardPicture);
            this.panel3.Controls.Add(this.CreditCardLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 150);
            this.panel3.TabIndex = 0;
            // 
            // CreditCardPicture
            // 
            this.CreditCardPicture.Image = global::Payment_form.Properties.Resources.credit_card;
            this.CreditCardPicture.Location = new System.Drawing.Point(23, 6);
            this.CreditCardPicture.Name = "CreditCardPicture";
            this.CreditCardPicture.Size = new System.Drawing.Size(100, 50);
            this.CreditCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreditCardPicture.TabIndex = 0;
            this.CreditCardPicture.TabStop = false;
            this.CreditCardPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreditCardLabel.Location = new System.Drawing.Point(20, 95);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(77, 17);
            this.CreditCardLabel.TabIndex = 1;
            this.CreditCardLabel.Text = "Credit card";
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(86, 39);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(92, 17);
            this.CreditCardNumberLabel.TabIndex = 0;
            this.CreditCardNumberLabel.Text = "Card Number";
            // 
            // CreditCardHolderLabel
            // 
            this.CreditCardHolderLabel.AutoSize = true;
            this.CreditCardHolderLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreditCardHolderLabel.Location = new System.Drawing.Point(86, 133);
            this.CreditCardHolderLabel.Name = "CreditCardHolderLabel";
            this.CreditCardHolderLabel.Size = new System.Drawing.Size(125, 17);
            this.CreditCardHolderLabel.TabIndex = 1;
            this.CreditCardHolderLabel.Text = "Card Holder Name";
            // 
            // CreditCardExpiryLabel
            // 
            this.CreditCardExpiryLabel.AutoSize = true;
            this.CreditCardExpiryLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreditCardExpiryLabel.Location = new System.Drawing.Point(86, 246);
            this.CreditCardExpiryLabel.Name = "CreditCardExpiryLabel";
            this.CreditCardExpiryLabel.Size = new System.Drawing.Size(118, 17);
            this.CreditCardExpiryLabel.TabIndex = 2;
            this.CreditCardExpiryLabel.Text = " Card Expiry Date";
            // 
            // CreditCVVLabel
            // 
            this.CreditCVVLabel.AutoSize = true;
            this.CreditCVVLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreditCVVLabel.Location = new System.Drawing.Point(86, 339);
            this.CreditCVVLabel.Name = "CreditCVVLabel";
            this.CreditCVVLabel.Size = new System.Drawing.Size(92, 17);
            this.CreditCVVLabel.TabIndex = 3;
            this.CreditCVVLabel.Text = "CVC/CVV/CID";
            // 
            // CreditCardNumberTextBox
            // 
            this.CreditCardNumberTextBox.Location = new System.Drawing.Point(353, 39);
            this.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox";
            this.CreditCardNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.CreditCardNumberTextBox.TabIndex = 4;
            // 
            // CreditCardHoldeTextBox
            // 
            this.CreditCardHoldeTextBox.Location = new System.Drawing.Point(353, 133);
            this.CreditCardHoldeTextBox.Name = "CreditCardHoldeTextBox";
            this.CreditCardHoldeTextBox.Size = new System.Drawing.Size(100, 22);
            this.CreditCardHoldeTextBox.TabIndex = 5;
            // 
            // CreditCardPanel
            // 
            this.CreditCardPanel.Controls.Add(this.DebitCardPanel);
            this.CreditCardPanel.Controls.Add(this.CreditCVVTextBox);
            this.CreditCardPanel.Controls.Add(this.CreditCardExpiryYearTextBox);
            this.CreditCardPanel.Controls.Add(this.CreditCardExpiryMonthTextBox);
            this.CreditCardPanel.Controls.Add(this.CreditCardHoldeTextBox);
            this.CreditCardPanel.Controls.Add(this.CreditCardNumberTextBox);
            this.CreditCardPanel.Controls.Add(this.CreditCVVLabel);
            this.CreditCardPanel.Controls.Add(this.CreditCardExpiryLabel);
            this.CreditCardPanel.Controls.Add(this.CreditCardHolderLabel);
            this.CreditCardPanel.Controls.Add(this.CreditCardNumberLabel);
            this.CreditCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditCardPanel.Location = new System.Drawing.Point(145, 125);
            this.CreditCardPanel.Name = "CreditCardPanel";
            this.CreditCardPanel.Size = new System.Drawing.Size(806, 452);
            this.CreditCardPanel.TabIndex = 2;
            this.CreditCardPanel.Visible = false;
            this.CreditCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CreditCardWindow_Paint);
            // 
            // CreditCVVTextBox
            // 
            this.CreditCVVTextBox.Location = new System.Drawing.Point(353, 334);
            this.CreditCVVTextBox.Name = "CreditCVVTextBox";
            this.CreditCVVTextBox.Size = new System.Drawing.Size(100, 22);
            this.CreditCVVTextBox.TabIndex = 8;
            // 
            // CreditCardExpiryYearTextBox
            // 
            this.CreditCardExpiryYearTextBox.Location = new System.Drawing.Point(414, 241);
            this.CreditCardExpiryYearTextBox.Name = "CreditCardExpiryYearTextBox";
            this.CreditCardExpiryYearTextBox.Size = new System.Drawing.Size(39, 22);
            this.CreditCardExpiryYearTextBox.TabIndex = 7;
            this.CreditCardExpiryYearTextBox.Text = "YY";
            // 
            // CreditCardExpiryMonthTextBox
            // 
            this.CreditCardExpiryMonthTextBox.Location = new System.Drawing.Point(353, 241);
            this.CreditCardExpiryMonthTextBox.Name = "CreditCardExpiryMonthTextBox";
            this.CreditCardExpiryMonthTextBox.Size = new System.Drawing.Size(36, 22);
            this.CreditCardExpiryMonthTextBox.TabIndex = 6;
            this.CreditCardExpiryMonthTextBox.Text = "MM";
            // 
            // DebitCardPanel
            // 
            this.DebitCardPanel.Controls.Add(this.ElectronicWalletPanel);
            this.DebitCardPanel.Controls.Add(this.DebitCVVTextBox);
            this.DebitCardPanel.Controls.Add(this.DebitCardExpiryYearTextBox);
            this.DebitCardPanel.Controls.Add(this.DebitCardExpiryMonthTextBox);
            this.DebitCardPanel.Controls.Add(this.DebitCardHoldeTextBox);
            this.DebitCardPanel.Controls.Add(this.DebitCardNumberTextBox);
            this.DebitCardPanel.Controls.Add(this.DebitCVVLabel);
            this.DebitCardPanel.Controls.Add(this.DebitCardExpiryLabel);
            this.DebitCardPanel.Controls.Add(this.DebitCardHolderLabel);
            this.DebitCardPanel.Controls.Add(this.DebitCardNumberLabel);
            this.DebitCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebitCardPanel.Location = new System.Drawing.Point(0, 0);
            this.DebitCardPanel.Name = "DebitCardPanel";
            this.DebitCardPanel.Size = new System.Drawing.Size(806, 452);
            this.DebitCardPanel.TabIndex = 9;
            // 
            // DebitCardNumberLabel
            // 
            this.DebitCardNumberLabel.AutoSize = true;
            this.DebitCardNumberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DebitCardNumberLabel.Location = new System.Drawing.Point(220, 68);
            this.DebitCardNumberLabel.Name = "DebitCardNumberLabel";
            this.DebitCardNumberLabel.Size = new System.Drawing.Size(92, 17);
            this.DebitCardNumberLabel.TabIndex = 9;
            this.DebitCardNumberLabel.Text = "Card Number";
            // 
            // DebitCardHolderLabel
            // 
            this.DebitCardHolderLabel.AutoSize = true;
            this.DebitCardHolderLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DebitCardHolderLabel.Location = new System.Drawing.Point(220, 162);
            this.DebitCardHolderLabel.Name = "DebitCardHolderLabel";
            this.DebitCardHolderLabel.Size = new System.Drawing.Size(125, 17);
            this.DebitCardHolderLabel.TabIndex = 10;
            this.DebitCardHolderLabel.Text = "Card Holder Name";
            // 
            // DebitCardExpiryLabel
            // 
            this.DebitCardExpiryLabel.AutoSize = true;
            this.DebitCardExpiryLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DebitCardExpiryLabel.Location = new System.Drawing.Point(220, 275);
            this.DebitCardExpiryLabel.Name = "DebitCardExpiryLabel";
            this.DebitCardExpiryLabel.Size = new System.Drawing.Size(118, 17);
            this.DebitCardExpiryLabel.TabIndex = 11;
            this.DebitCardExpiryLabel.Text = " Card Expiry Date";
            // 
            // DebitCVVLabel
            // 
            this.DebitCVVLabel.AutoSize = true;
            this.DebitCVVLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DebitCVVLabel.Location = new System.Drawing.Point(220, 368);
            this.DebitCVVLabel.Name = "DebitCVVLabel";
            this.DebitCVVLabel.Size = new System.Drawing.Size(92, 17);
            this.DebitCVVLabel.TabIndex = 12;
            this.DebitCVVLabel.Text = "CVC/CVV/CID";
            // 
            // DebitCardHoldeTextBox
            // 
            this.DebitCardHoldeTextBox.Location = new System.Drawing.Point(487, 162);
            this.DebitCardHoldeTextBox.Name = "DebitCardHoldeTextBox";
            this.DebitCardHoldeTextBox.Size = new System.Drawing.Size(100, 22);
            this.DebitCardHoldeTextBox.TabIndex = 14;
            // 
            // DebitCardExpiryMonthTextBox
            // 
            this.DebitCardExpiryMonthTextBox.Location = new System.Drawing.Point(487, 270);
            this.DebitCardExpiryMonthTextBox.Name = "DebitCardExpiryMonthTextBox";
            this.DebitCardExpiryMonthTextBox.Size = new System.Drawing.Size(36, 22);
            this.DebitCardExpiryMonthTextBox.TabIndex = 15;
            this.DebitCardExpiryMonthTextBox.Text = "MM";
            // 
            // DebitCardExpiryYearTextBox
            // 
            this.DebitCardExpiryYearTextBox.Location = new System.Drawing.Point(548, 270);
            this.DebitCardExpiryYearTextBox.Name = "DebitCardExpiryYearTextBox";
            this.DebitCardExpiryYearTextBox.Size = new System.Drawing.Size(39, 22);
            this.DebitCardExpiryYearTextBox.TabIndex = 16;
            this.DebitCardExpiryYearTextBox.Text = "YY";
            // 
            // DebitCVVTextBox
            // 
            this.DebitCVVTextBox.Location = new System.Drawing.Point(487, 363);
            this.DebitCVVTextBox.Name = "DebitCVVTextBox";
            this.DebitCVVTextBox.Size = new System.Drawing.Size(100, 22);
            this.DebitCVVTextBox.TabIndex = 17;
            // 
            // DebitCardNumberTextBox
            // 
            this.DebitCardNumberTextBox.Location = new System.Drawing.Point(487, 68);
            this.DebitCardNumberTextBox.Name = "DebitCardNumberTextBox";
            this.DebitCardNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.DebitCardNumberTextBox.TabIndex = 13;
            // 
            // ElectronicCardNumberLabel
            // 
            this.ElectronicCardNumberLabel.AutoSize = true;
            this.ElectronicCardNumberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ElectronicCardNumberLabel.Location = new System.Drawing.Point(220, 68);
            this.ElectronicCardNumberLabel.Name = "ElectronicCardNumberLabel";
            this.ElectronicCardNumberLabel.Size = new System.Drawing.Size(92, 17);
            this.ElectronicCardNumberLabel.TabIndex = 18;
            this.ElectronicCardNumberLabel.Text = "Card Number";
            // 
            // ElectronicCardHolderLabel
            // 
            this.ElectronicCardHolderLabel.AutoSize = true;
            this.ElectronicCardHolderLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ElectronicCardHolderLabel.Location = new System.Drawing.Point(220, 162);
            this.ElectronicCardHolderLabel.Name = "ElectronicCardHolderLabel";
            this.ElectronicCardHolderLabel.Size = new System.Drawing.Size(125, 17);
            this.ElectronicCardHolderLabel.TabIndex = 19;
            this.ElectronicCardHolderLabel.Text = "Card Holder Name";
            // 
            // ElectronicCardExpiryLabel
            // 
            this.ElectronicCardExpiryLabel.AutoSize = true;
            this.ElectronicCardExpiryLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ElectronicCardExpiryLabel.Location = new System.Drawing.Point(220, 275);
            this.ElectronicCardExpiryLabel.Name = "ElectronicCardExpiryLabel";
            this.ElectronicCardExpiryLabel.Size = new System.Drawing.Size(118, 17);
            this.ElectronicCardExpiryLabel.TabIndex = 20;
            this.ElectronicCardExpiryLabel.Text = " Card Expiry Date";
            // 
            // ElectronicCardCVVLabel
            // 
            this.ElectronicCardCVVLabel.AutoSize = true;
            this.ElectronicCardCVVLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ElectronicCardCVVLabel.Location = new System.Drawing.Point(220, 368);
            this.ElectronicCardCVVLabel.Name = "ElectronicCardCVVLabel";
            this.ElectronicCardCVVLabel.Size = new System.Drawing.Size(92, 17);
            this.ElectronicCardCVVLabel.TabIndex = 21;
            this.ElectronicCardCVVLabel.Text = "CVC/CVV/CID";
            // 
            // ElectronicCardNumberTextBox
            // 
            this.ElectronicCardNumberTextBox.Location = new System.Drawing.Point(487, 68);
            this.ElectronicCardNumberTextBox.Name = "ElectronicCardNumberTextBox";
            this.ElectronicCardNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.ElectronicCardNumberTextBox.TabIndex = 22;
            // 
            // ElectronicCardHolderTextBox
            // 
            this.ElectronicCardHolderTextBox.Location = new System.Drawing.Point(487, 162);
            this.ElectronicCardHolderTextBox.Name = "ElectronicCardHolderTextBox";
            this.ElectronicCardHolderTextBox.Size = new System.Drawing.Size(100, 22);
            this.ElectronicCardHolderTextBox.TabIndex = 23;
            // 
            // ElectronicCardExpiryMonthTextBox
            // 
            this.ElectronicCardExpiryMonthTextBox.Location = new System.Drawing.Point(487, 270);
            this.ElectronicCardExpiryMonthTextBox.Name = "ElectronicCardExpiryMonthTextBox";
            this.ElectronicCardExpiryMonthTextBox.Size = new System.Drawing.Size(36, 22);
            this.ElectronicCardExpiryMonthTextBox.TabIndex = 24;
            this.ElectronicCardExpiryMonthTextBox.Text = "MM";
            // 
            // ElectronicCardExpityYearTextBox
            // 
            this.ElectronicCardExpityYearTextBox.Location = new System.Drawing.Point(548, 270);
            this.ElectronicCardExpityYearTextBox.Name = "ElectronicCardExpityYearTextBox";
            this.ElectronicCardExpityYearTextBox.Size = new System.Drawing.Size(39, 22);
            this.ElectronicCardExpityYearTextBox.TabIndex = 25;
            this.ElectronicCardExpityYearTextBox.Text = "YY";
            // 
            // ElectronicCardCVVTextBox
            // 
            this.ElectronicCardCVVTextBox.Location = new System.Drawing.Point(487, 363);
            this.ElectronicCardCVVTextBox.Name = "ElectronicCardCVVTextBox";
            this.ElectronicCardCVVTextBox.Size = new System.Drawing.Size(100, 22);
            this.ElectronicCardCVVTextBox.TabIndex = 26;
            // 
            // ElectronicWalletPanel
            // 
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardCVVTextBox);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardExpityYearTextBox);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardExpiryMonthTextBox);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardHolderTextBox);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardNumberTextBox);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardCVVLabel);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardExpiryLabel);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardHolderLabel);
            this.ElectronicWalletPanel.Controls.Add(this.ElectronicCardNumberLabel);
            this.ElectronicWalletPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElectronicWalletPanel.Location = new System.Drawing.Point(0, 0);
            this.ElectronicWalletPanel.Name = "ElectronicWalletPanel";
            this.ElectronicWalletPanel.Size = new System.Drawing.Size(806, 452);
            this.ElectronicWalletPanel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.CreditCardPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentMethodPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectronicWalletPicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebitCardPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditCardPicture)).EndInit();
            this.CreditCardPanel.ResumeLayout(false);
            this.CreditCardPanel.PerformLayout();
            this.DebitCardPanel.ResumeLayout(false);
            this.DebitCardPanel.PerformLayout();
            this.ElectronicWalletPanel.ResumeLayout(false);
            this.ElectronicWalletPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.PictureBox PaymentMethodPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ElectronicWalletPicture;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox DebitCardPicture;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox CreditCardPicture;
        private System.Windows.Forms.Label ElectronicWalletLabel;
        private System.Windows.Forms.Label DebitCardLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.Label CreditCardNumberLabel;
        private System.Windows.Forms.Label CreditCardHolderLabel;
        private System.Windows.Forms.Label CreditCardExpiryLabel;
        private System.Windows.Forms.Label CreditCVVLabel;
        private System.Windows.Forms.TextBox CreditCardNumberTextBox;
        private System.Windows.Forms.TextBox CreditCardHoldeTextBox;
        private System.Windows.Forms.Panel CreditCardPanel;
        private System.Windows.Forms.TextBox CreditCVVTextBox;
        private System.Windows.Forms.TextBox CreditCardExpiryYearTextBox;
        private System.Windows.Forms.TextBox CreditCardExpiryMonthTextBox;
        private System.Windows.Forms.Panel DebitCardPanel;
        private System.Windows.Forms.Panel ElectronicWalletPanel;
        private System.Windows.Forms.TextBox ElectronicCardCVVTextBox;
        private System.Windows.Forms.TextBox ElectronicCardExpityYearTextBox;
        private System.Windows.Forms.TextBox ElectronicCardExpiryMonthTextBox;
        private System.Windows.Forms.TextBox ElectronicCardHolderTextBox;
        private System.Windows.Forms.TextBox ElectronicCardNumberTextBox;
        private System.Windows.Forms.Label ElectronicCardCVVLabel;
        private System.Windows.Forms.Label ElectronicCardExpiryLabel;
        private System.Windows.Forms.Label ElectronicCardHolderLabel;
        private System.Windows.Forms.Label ElectronicCardNumberLabel;
        private System.Windows.Forms.TextBox DebitCVVTextBox;
        private System.Windows.Forms.TextBox DebitCardExpiryYearTextBox;
        private System.Windows.Forms.TextBox DebitCardExpiryMonthTextBox;
        private System.Windows.Forms.TextBox DebitCardHoldeTextBox;
        private System.Windows.Forms.TextBox DebitCardNumberTextBox;
        private System.Windows.Forms.Label DebitCVVLabel;
        private System.Windows.Forms.Label DebitCardExpiryLabel;
        private System.Windows.Forms.Label DebitCardHolderLabel;
        private System.Windows.Forms.Label DebitCardNumberLabel;
    }
}

