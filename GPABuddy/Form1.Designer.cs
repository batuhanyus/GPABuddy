namespace GPABuddy
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.renameProfileBox = new System.Windows.Forms.TextBox();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.profilesBox = new System.Windows.Forms.ListBox();
            this.renameProfileButton = new System.Windows.Forms.Button();
            this.newProfileButton = new System.Windows.Forms.Button();
            this.loadProfileButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.programSelector = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.programTextBox = new System.Windows.Forms.RichTextBox();
            this.programTable = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.programSaveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 705);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.renameProfileBox);
            this.tabPage1.Controls.Add(this.deleteProfileButton);
            this.tabPage1.Controls.Add(this.profilesBox);
            this.tabPage1.Controls.Add(this.renameProfileButton);
            this.tabPage1.Controls.Add(this.newProfileButton);
            this.tabPage1.Controls.Add(this.loadProfileButton);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.programSelector);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş";
            // 
            // renameProfileBox
            // 
            this.renameProfileBox.Location = new System.Drawing.Point(228, 63);
            this.renameProfileBox.Name = "renameProfileBox";
            this.renameProfileBox.Size = new System.Drawing.Size(152, 20);
            this.renameProfileBox.TabIndex = 9;
            this.renameProfileBox.Text = "yeni ad...";
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Enabled = false;
            this.deleteProfileButton.Location = new System.Drawing.Point(137, 121);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(243, 23);
            this.deleteProfileButton.TabIndex = 8;
            this.deleteProfileButton.Text = "Profili Sil";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // profilesBox
            // 
            this.profilesBox.FormattingEnabled = true;
            this.profilesBox.Location = new System.Drawing.Point(6, 33);
            this.profilesBox.Name = "profilesBox";
            this.profilesBox.Size = new System.Drawing.Size(125, 108);
            this.profilesBox.TabIndex = 7;
            this.profilesBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // renameProfileButton
            // 
            this.renameProfileButton.Enabled = false;
            this.renameProfileButton.Location = new System.Drawing.Point(137, 62);
            this.renameProfileButton.Name = "renameProfileButton";
            this.renameProfileButton.Size = new System.Drawing.Size(84, 23);
            this.renameProfileButton.TabIndex = 6;
            this.renameProfileButton.Text = "Profili Adlandır";
            this.renameProfileButton.UseVisualStyleBackColor = true;
            this.renameProfileButton.Click += new System.EventHandler(this.renameProfileButton_Click);
            // 
            // newProfileButton
            // 
            this.newProfileButton.Enabled = false;
            this.newProfileButton.Location = new System.Drawing.Point(137, 91);
            this.newProfileButton.Name = "newProfileButton";
            this.newProfileButton.Size = new System.Drawing.Size(243, 23);
            this.newProfileButton.TabIndex = 5;
            this.newProfileButton.Text = "Yeni Profil";
            this.newProfileButton.UseVisualStyleBackColor = true;
            this.newProfileButton.Click += new System.EventHandler(this.newProfileButton_Click);
            // 
            // loadProfileButton
            // 
            this.loadProfileButton.Enabled = false;
            this.loadProfileButton.Location = new System.Drawing.Point(137, 33);
            this.loadProfileButton.Name = "loadProfileButton";
            this.loadProfileButton.Size = new System.Drawing.Size(243, 23);
            this.loadProfileButton.TabIndex = 4;
            this.loadProfileButton.Text = "Profili Yükle";
            this.loadProfileButton.UseVisualStyleBackColor = true;
            this.loadProfileButton.Click += new System.EventHandler(this.loadProfileButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(386, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(581, 665);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "GPA Buddy Kullanım Kılavuzu\n\n1. Giriş sekmesindeki soldaki listeden programınızı " +
    "seçiniz.";
            // 
            // programSelector
            // 
            this.programSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programSelector.FormattingEnabled = true;
            this.programSelector.Items.AddRange(new object[] {
            "İktisat Programı (Türkçe)"});
            this.programSelector.Location = new System.Drawing.Point(6, 6);
            this.programSelector.Name = "programSelector";
            this.programSelector.Size = new System.Drawing.Size(374, 21);
            this.programSelector.TabIndex = 0;
            this.programSelector.TabStop = false;
            this.programSelector.SelectedIndexChanged += new System.EventHandler(this.programSelector_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.programSaveButton);
            this.tabPage2.Controls.Add(this.programTextBox);
            this.tabPage2.Controls.Add(this.programTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğretim Programı";
            // 
            // programTextBox
            // 
            this.programTextBox.BackColor = System.Drawing.Color.Gray;
            this.programTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programTextBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTextBox.Location = new System.Drawing.Point(827, 6);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.ReadOnly = true;
            this.programTextBox.Size = new System.Drawing.Size(142, 153);
            this.programTextBox.TabIndex = 3;
            this.programTextBox.Text = "Toplam AKTS: XXX\nToplam \"Puan\": XXX\nDiploma Notu: XXX";
            // 
            // programTable
            // 
            this.programTable.AutoScroll = true;
            this.programTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.programTable.ColumnCount = 5;
            this.programTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.programTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.programTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.programTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.programTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.programTable.Location = new System.Drawing.Point(6, 6);
            this.programTable.Name = "programTable";
            this.programTable.RowCount = 1;
            this.programTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.programTable.Size = new System.Drawing.Size(815, 665);
            this.programTable.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(975, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dönem Planlayıcı";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(7, 621);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(373, 49);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "GPA Buddy Güncel";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveTimer
            // 
            this.saveTimer.Interval = 5000;
            this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
            // 
            // programSaveButton
            // 
            this.programSaveButton.Location = new System.Drawing.Point(828, 166);
            this.programSaveButton.Name = "programSaveButton";
            this.programSaveButton.Size = new System.Drawing.Size(139, 40);
            this.programSaveButton.TabIndex = 4;
            this.programSaveButton.Text = "Kaydet";
            this.programSaveButton.UseVisualStyleBackColor = true;
            this.programSaveButton.Click += new System.EventHandler(this.programSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GPA Buddy";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox programSelector;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TableLayoutPanel programTable;
        private System.Windows.Forms.Button renameProfileButton;
        private System.Windows.Forms.Button newProfileButton;
        private System.Windows.Forms.Button loadProfileButton;
        private System.Windows.Forms.ListBox profilesBox;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button deleteProfileButton;
        public System.Windows.Forms.TextBox renameProfileBox;
        public System.Windows.Forms.RichTextBox programTextBox;
        public System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.Button programSaveButton;
    }
}

