using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            todayDateTime.Value = DateTime.Now;
            nowTime.Value = DateTime.Now;
        }

        private void todayTimer_Tick(object sender, EventArgs e)
        {
            todayDateTime.Value = DateTime.Now;
            nowTime.Value = DateTime.Now;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String surname = surnameTextBox.Text;
            int bornDateYear = bornDatePicker.Value.Year;

            if(bornDatePicker.Value.DayOfYear <= todayDateTime.Value.DayOfYear && bornDateYear <= todayDateTime.Value.Year)
            {
                int selStart;

                userData.AppendText(name + " ");

                selStart = userData.Text.Length;

                userData.AppendText(surname + " ");

                userData.Select(selStart, userData.Text.Length);

                userData.SelectionFont = new Font(userData.Font, FontStyle.Bold);

                userData.Select(0, 0);

                userData.SelectionFont = new Font(userData.Font, FontStyle.Regular);

                userData.AppendText("lat " + (todayDateTime.Value.Year - bornDateYear) + " ");

                selStart = userData.Text.Length;

                userData.AppendText(bornDatePicker.Value.ToShortDateString());

                userData.Select(selStart, userData.Text.Length);

                if (ageBox.Value >= 18)
                {
                    userData.SelectionColor = Color.Blue;
                }
                else
                {
                    userData.SelectionColor = Color.Green;
                }

                userData.Select(0, 0);

                userData.SelectionColor = Color.Black;

                userData.AppendText("\n");

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = @"C:\",
                    RestoreDirectory = true,
                    Title = "Open Rtf Files",
                    DefaultExt = "rtf",
                    Filter = "Rtf files (*.rtf)|*.rtf|All files (*.*)|*.*",
                    CheckPathExists = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter fileWriter = new StreamWriter(saveFileDialog.OpenFile());

                        if (userData.Rtf != null)
                        { 
                            fileWriter.Write(nowTime.Value + "\n");
                            fileWriter.Write(userData.Rtf);
                        }

                        fileWriter.Flush();
                        fileWriter.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error: " + exc.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niepoprawna data urodzenia!");
            }
        }

        private void Font_CheckedChanged(object sender, EventArgs e)
        {
            var selectedFont = FontBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            FontStyle style = userData.Font.Style;

            switch (selectedFont.Name)
            {
                case "ArialFont":
                    { 
                        userData.Font = new Font("Arial", userData.Font.Size, style);
                        break;
                    }

                case "TimesNewRomanFont":
                    {
                        userData.Font = new Font("Times New Roman", userData.Font.Size, style);
                        break;
                    }
            }
        }

        private void bornDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (todayDateTime.Value.Year - bornDatePicker.Value.Year >= 0)
                ageBox.Value = todayDateTime.Value.Year - bornDatePicker.Value.Year;
        }
    }
}
