
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
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.todayLabel = new System.Windows.Forms.Label();
            this.todayDateTime = new System.Windows.Forms.DateTimePicker();
            this.todayTimer = new System.Windows.Forms.Timer(this.components);
            this.nowTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(161, 57);
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
            this.surnameLabel.Location = new System.Drawing.Point(179, 28);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(334, 27);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 15);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Wiek";
            // 
            // bornDateLabel
            // 
            this.bornDateLabel.AutoSize = true;
            this.bornDateLabel.Location = new System.Drawing.Point(440, 28);
            this.bornDateLabel.Name = "bornDateLabel";
            this.bornDateLabel.Size = new System.Drawing.Size(86, 15);
            this.bornDateLabel.TabIndex = 5;
            this.bornDateLabel.Text = "Data urodzenia";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(303, 57);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 23);
            this.ageTextBox.TabIndex = 6;
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bornDatePicker.Location = new System.Drawing.Point(440, 57);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(78, 23);
            this.bornDatePicker.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.nowTime);
            this.Controls.Add(this.todayDateTime);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.bornDateLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.DateTimePicker todayDateTime;
        private System.Windows.Forms.Timer todayTimer;
        private System.Windows.Forms.DateTimePicker nowTime;
    }
}

