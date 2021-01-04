using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_form
{
    public partial class FeedbackForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox4;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox5;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox6;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox7;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox8;
        private Label label10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label11;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox2;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;

        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox8 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2CustomCheckBox2 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(394, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "We value your Feedback!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(296, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please complete the following form and help us improve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(388, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "out Customers experience.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(226, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Very satsfied";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(377, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Satisfied";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(518, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unsatisfied";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(656, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Very unsatisfied";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(108, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 54);
            this.label8.TabIndex = 9;
            this.label8.Text = "How satisfied are you with our services?";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(108, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 56);
            this.label9.TabIndex = 10;
            this.label9.Text = "How satisfied are you with our team?";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(263, 215);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox1.TabIndex = 11;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Location = new System.Drawing.Point(397, 215);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox2.TabIndex = 12;
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.Location = new System.Drawing.Point(546, 215);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox3.TabIndex = 13;
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox4
            // 
            this.guna2CheckBox4.AutoSize = true;
            this.guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.CheckedState.BorderRadius = 0;
            this.guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.Location = new System.Drawing.Point(263, 319);
            this.guna2CheckBox4.Name = "guna2CheckBox4";
            this.guna2CheckBox4.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox4.TabIndex = 14;
            this.guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox5
            // 
            this.guna2CheckBox5.AutoSize = true;
            this.guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.CheckedState.BorderRadius = 0;
            this.guna2CheckBox5.CheckedState.BorderThickness = 0;
            this.guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.Location = new System.Drawing.Point(397, 319);
            this.guna2CheckBox5.Name = "guna2CheckBox5";
            this.guna2CheckBox5.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox5.TabIndex = 15;
            this.guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox5.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox5.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox6
            // 
            this.guna2CheckBox6.AutoSize = true;
            this.guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.CheckedState.BorderRadius = 0;
            this.guna2CheckBox6.CheckedState.BorderThickness = 0;
            this.guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.Location = new System.Drawing.Point(546, 319);
            this.guna2CheckBox6.Name = "guna2CheckBox6";
            this.guna2CheckBox6.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox6.TabIndex = 16;
            this.guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox6.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox6.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox7
            // 
            this.guna2CheckBox7.AutoSize = true;
            this.guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.CheckedState.BorderRadius = 0;
            this.guna2CheckBox7.CheckedState.BorderThickness = 0;
            this.guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.Location = new System.Drawing.Point(698, 215);
            this.guna2CheckBox7.Name = "guna2CheckBox7";
            this.guna2CheckBox7.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox7.TabIndex = 17;
            this.guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox7.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox7.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox8
            // 
            this.guna2CheckBox8.AutoSize = true;
            this.guna2CheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox8.CheckedState.BorderRadius = 0;
            this.guna2CheckBox8.CheckedState.BorderThickness = 0;
            this.guna2CheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox8.Location = new System.Drawing.Point(698, 319);
            this.guna2CheckBox8.Name = "guna2CheckBox8";
            this.guna2CheckBox8.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox8.TabIndex = 18;
            this.guna2CheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox8.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox8.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(69, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tell us how we can improve!";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 38;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(72, 398);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(743, 78);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Cyan;
            this.label11.Location = new System.Drawing.Point(87, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Would you like a representative to contact you?";
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(153, 532);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 22;
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
            // 
            // guna2CustomCheckBox2
            // 
            this.guna2CustomCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox2.CheckedState.Parent = this.guna2CustomCheckBox2;
            this.guna2CustomCheckBox2.Location = new System.Drawing.Point(352, 532);
            this.guna2CustomCheckBox2.Name = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.ShadowDecoration.Parent = this.guna2CustomCheckBox2;
            this.guna2CustomCheckBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox2.TabIndex = 23;
            this.guna2CustomCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox2.UncheckedState.Parent = this.guna2CustomCheckBox2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(199, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Yes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Cyan;
            this.label13.Location = new System.Drawing.Point(394, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "No";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FeedbackForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(933, 577);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2CustomCheckBox2);
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2CheckBox8);
            this.Controls.Add(this.guna2CheckBox7);
            this.Controls.Add(this.guna2CheckBox6);
            this.Controls.Add(this.guna2CheckBox5);
            this.Controls.Add(this.guna2CheckBox4);
            this.Controls.Add(this.guna2CheckBox3);
            this.Controls.Add(this.guna2CheckBox2);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
