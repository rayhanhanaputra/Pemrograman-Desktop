namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            comboBox2 = new ComboBox();
            label17 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 28);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 0;
            label1.Text = "Caffe PoltekSSN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 77);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 1;
            label2.Text = "Menu";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 122);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Rp10.000";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 151);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Rp15.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 181);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 7;
            label8.Text = "Rp12.000";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(32, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Espresso";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(32, 149);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Latte";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(32, 181);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 24);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cappuccino";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 31);
            label3.TabIndex = 11;
            label3.Text = "Size";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 122);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 14;
            label4.Text = "+Rp3.000";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 237);
            label5.Name = "label5";
            label5.Size = new Size(102, 31);
            label5.TabIndex = 15;
            label5.Text = "Topping";
            label5.Click += label5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata de coco", "Whipped cream", "Choco chip", "Oreo" });
            checkedListBox1.Location = new Point(32, 280);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 136);
            checkedListBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 280);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 17;
            label9.Text = "+Rp3.000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 304);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 18;
            label10.Text = "+Rp3.500";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(188, 328);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 19;
            label11.Text = "+Rp2.500";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(188, 351);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 20;
            label12.Text = "+Rp1.000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(188, 372);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 21;
            label13.Text = "+Rp1.500";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(188, 392);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 22;
            label14.Text = "+Rp2.000";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "100", "75", "50", "0" });
            comboBox1.Location = new Point(557, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(550, 77);
            label15.Name = "label15";
            label15.Size = new Size(137, 31);
            label15.TabIndex = 24;
            label15.Text = "Sugar Level";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(550, 167);
            label16.Name = "label16";
            label16.Size = new Size(105, 31);
            label16.TabIndex = 25;
            label16.Text = "Ice Level";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100", "75", "50", "0" });
            comboBox2.Location = new Point(557, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 26;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(511, 271);
            label17.Name = "label17";
            label17.Size = new Size(91, 31);
            label17.TabIndex = 27;
            label17.Text = "Invoice";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(329, 280);
            button1.Name = "button1";
            button1.Size = new Size(143, 88);
            button1.TabIndex = 28;
            button1.Text = "CHECK OUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(314, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 24);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "Large";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(714, 125);
            label18.Name = "label18";
            label18.Size = new Size(21, 20);
            label18.TabIndex = 30;
            label18.Text = "%";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(714, 216);
            label19.Name = "label19";
            label19.Size = new Size(21, 20);
            label19.TabIndex = 31;
            label19.Text = "%";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(672, 406);
            label20.Name = "label20";
            label20.Size = new Size(49, 28);
            label20.TabIndex = 32;
            label20.Text = "Rp0";
            label20.Click += label20_Click;
            // 
            // label21
            // 
            label21.AllowDrop = true;
            label21.AutoSize = true;
            label21.Location = new Point(513, 311);
            label21.Name = "label21";
            label21.Size = new Size(15, 20);
            label21.TabIndex = 33;
            label21.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(512, 406);
            label22.Name = "label22";
            label22.Size = new Size(148, 28);
            label22.TabIndex = 34;
            label22.Text = "TOTAL HARGA";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, manageUserToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(110, 24);
            manageUserToolStripMenuItem.Text = "Manage User";
            manageUserToolStripMenuItem.Click += manageUserToolStripMenuItem_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // button2
            // 
            button2.Location = new Point(353, 392);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(94, 29);
            button2.TabIndex = 36;
            button2.Text = "PRINT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label17);
            Controls.Add(comboBox2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(comboBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox1;
        private Label label15;
        private Label label16;
        private ComboBox comboBox2;
        private Label label17;
        private Button button1;
        private CheckBox checkBox1;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button2;
    }
}