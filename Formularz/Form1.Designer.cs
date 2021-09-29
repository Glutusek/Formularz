
namespace Formularz
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
            this.components = new System.ComponentModel.Container();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.bornDateLabel = new System.Windows.Forms.Label();
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.todayLabel = new System.Windows.Forms.Label();
            this.todayDateTime = new System.Windows.Forms.DateTimePicker();
            this.todayTimer = new System.Windows.Forms.Timer(this.components);
            this.nowTime = new System.Windows.Forms.DateTimePicker();
            this.checkButton = new System.Windows.Forms.Button();
            this.userData = new System.Windows.Forms.RichTextBox();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.FontBox = new System.Windows.Forms.GroupBox();
            this.TimesNewRomanFont = new System.Windows.Forms.RadioButton();
            this.ArialFont = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.FontBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(136, 57);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 23);
            this.surnameTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(41, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(150, 28);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(292, 27);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 15);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Wiek";
            // 
            // bornDateLabel
            // 
            this.bornDateLabel.AutoSize = true;
            this.bornDateLabel.Location = new System.Drawing.Point(392, 28);
            this.bornDateLabel.Name = "bornDateLabel";
            this.bornDateLabel.Size = new System.Drawing.Size(86, 15);
            this.bornDateLabel.TabIndex = 5;
            this.bornDateLabel.Text = "Data urodzenia";
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bornDatePicker.Location = new System.Drawing.Point(400, 57);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(78, 23);
            this.bornDatePicker.TabIndex = 7;
            this.bornDatePicker.ValueChanged += new System.EventHandler(this.bornDatePicker_ValueChanged);
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Location = new System.Drawing.Point(722, 27);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(40, 15);
            this.todayLabel.TabIndex = 8;
            this.todayLabel.Text = "Dzisiaj";
            // 
            // todayDateTime
            // 
            this.todayDateTime.CustomFormat = "dd.MM.yyyy";
            this.todayDateTime.Enabled = false;
            this.todayDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todayDateTime.Location = new System.Drawing.Point(668, 54);
            this.todayDateTime.Name = "todayDateTime";
            this.todayDateTime.Size = new System.Drawing.Size(77, 23);
            this.todayDateTime.TabIndex = 9;
            // 
            // todayTimer
            // 
            this.todayTimer.Enabled = true;
            this.todayTimer.Interval = 10000;
            this.todayTimer.Tick += new System.EventHandler(this.todayTimer_Tick);
            // 
            // nowTime
            // 
            this.nowTime.CustomFormat = "HH:mm";
            this.nowTime.Enabled = false;
            this.nowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nowTime.Location = new System.Drawing.Point(751, 54);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(51, 23);
            this.nowTime.TabIndex = 10;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(109, 148);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(117, 41);
            this.checkButton.TabIndex = 11;
            this.checkButton.Text = "Wyświetl i zapisz";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // userData
            // 
            this.userData.Location = new System.Drawing.Point(41, 205);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(255, 246);
            this.userData.TabIndex = 12;
            this.userData.Text = "";
            // 
            // ageBox
            // 
            this.ageBox.Enabled = false;
            this.ageBox.Location = new System.Drawing.Point(280, 57);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(62, 23);
            this.ageBox.TabIndex = 13;
            // 
            // FontBox
            // 
            this.FontBox.Controls.Add(this.TimesNewRomanFont);
            this.FontBox.Controls.Add(this.ArialFont);
            this.FontBox.Location = new System.Drawing.Point(337, 267);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(141, 81);
            this.FontBox.TabIndex = 14;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Font";
            // 
            // TimesNewRomanFont
            // 
            this.TimesNewRomanFont.AutoSize = true;
            this.TimesNewRomanFont.Location = new System.Drawing.Point(7, 49);
            this.TimesNewRomanFont.Name = "TimesNewRomanFont";
            this.TimesNewRomanFont.Size = new System.Drawing.Size(124, 19);
            this.TimesNewRomanFont.TabIndex = 1;
            this.TimesNewRomanFont.TabStop = true;
            this.TimesNewRomanFont.Text = "Times New Roman";
            this.TimesNewRomanFont.UseVisualStyleBackColor = true;
            this.TimesNewRomanFont.CheckedChanged += new System.EventHandler(this.Font_CheckedChanged);
            // 
            // ArialFont
            // 
            this.ArialFont.AutoSize = true;
            this.ArialFont.Location = new System.Drawing.Point(7, 23);
            this.ArialFont.Name = "ArialFont";
            this.ArialFont.Size = new System.Drawing.Size(49, 19);
            this.ArialFont.TabIndex = 0;
            this.ArialFont.TabStop = true;
            this.ArialFont.Text = "Arial";
            this.ArialFont.UseVisualStyleBackColor = true;
            this.ArialFont.CheckedChanged += new System.EventHandler(this.Font_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.nowTime);
            this.Controls.Add(this.todayDateTime);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.bornDateLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.FontBox.ResumeLayout(false);
            this.FontBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label bornDateLabel;
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.DateTimePicker todayDateTime;
        private System.Windows.Forms.Timer todayTimer;
        private System.Windows.Forms.DateTimePicker nowTime;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RichTextBox userData;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.GroupBox FontBox;
        private System.Windows.Forms.RadioButton TimesNewRomanFont;
        private System.Windows.Forms.RadioButton ArialFont;
    }
}

