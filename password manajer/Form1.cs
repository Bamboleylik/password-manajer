using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace password_manajer
{
    public partial class Form1 : Form
    {
        private string historyFile = "password_history.txt";

        public Form1()
        {
            InitializeComponent();
            LoadPasswordHistory();
            statusLabel.Text = "Оберіть режим: генерація або перевірка пароля";
            picStrength.SizeMode = PictureBoxSizeMode.Zoom;
            rbGenerate.Checked = true;
            txtPassword.ReadOnly = true;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.Size = new System.Drawing.Size(1000, 600);
        }

     
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (rbGenerate.Checked)
            {
                string password = GeneratePassword();
                if (!string.IsNullOrEmpty(password))
                {
                    txtPassword.Text = password;
                    AddToHistory(password);
                    UpdatePasswordStrength(password);
                    statusLabel.Text = "Пароль згенеровано!";
                }
                txtPassword.ReadOnly = true;
            }
            else if (rbCheck.Checked)
            {
                string password = txtPassword.Text;
                UpdatePasswordStrength(password);
                statusLabel.Text = "Перевірка пароля завершена";
                txtPassword.ReadOnly = false;
            }
        }

        private string GeneratePassword()
        {
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()-_=+";

            StringBuilder charSet = new StringBuilder();
            List<char> password = new List<char>();
            Random rand = new Random();

            if (chkLetters.Checked) charSet.Append(letters);
            if (chkNumbers.Checked) charSet.Append(numbers);
            if (chkSymbols.Checked) charSet.Append(symbols);

         
            if (charSet.Length == 0)
            {
                MessageBox.Show("Оберіть хоча б один тип символів!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            int length = Convert.ToInt32(numLength.Value);
            int selectedCategories = (chkLetters.Checked ? 1 : 0) + (chkNumbers.Checked ? 1 : 0) + (chkSymbols.Checked ? 1 : 0);

         
            if (length < selectedCategories)
            {
                MessageBox.Show($"Довжина пароля має бути принаймні {selectedCategories}!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

           
            if (chkLetters.Checked) password.Add(letters[rand.Next(letters.Length)]);
            if (chkNumbers.Checked) password.Add(numbers[rand.Next(numbers.Length)]);
            if (chkSymbols.Checked) password.Add(symbols[rand.Next(symbols.Length)]);

           
            for (int i = password.Count; i < length; i++)
            {
                password.Add(charSet[rand.Next(charSet.Length)]);
            }

          
            password = password.OrderBy(x => rand.Next()).ToList();
            return new string(password.ToArray());
        }

        private void UpdatePasswordStrength(string password)
        {
            int score = 0;
            if (password.Length >= 8) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(ch => "!@#$%^&*()-_=+".Contains(ch))) score++;

            pbStrength.Value = score * 20;
            pbStrength.ForeColor = GetStrengthColor(score);

           
            switch (score)
            {
                case 1: lblStrength.Text = "Дуже слабкий"; break;
                case 2: lblStrength.Text = "Слабкий"; break;
                case 3: lblStrength.Text = "Середній"; break;
                case 4: lblStrength.Text = "Сильний"; break;
                case 5: lblStrength.Text = "Дуже сильний"; break;
                default: lblStrength.Text = "Немає пароля"; break;
            }

       
            picStrength.Image = GetStrengthImage(score);
        }

        private System.Drawing.Color GetStrengthColor(int score)
        {
            switch (score)
            {
                case 1: return System.Drawing.Color.Red;
                case 2: return System.Drawing.Color.Orange;
                case 3: return System.Drawing.Color.Yellow;
                case 4: return System.Drawing.Color.GreenYellow;
                case 5: return System.Drawing.Color.Green;
                default: return System.Drawing.Color.Gray;
            }
        }

       
        private System.Drawing.Image GetStrengthImage(int score)
        {
            string[] imagePaths =
            {
                "C:\\Users\\asus\\Desktop\\final_project\\password manajer\\password manajer\\very_weak.jpg",
                "C:\\Users\\asus\\Desktop\\final_project\\password manajer\\password manajer\\weak.png",
                "C:\\Users\\asus\\Desktop\\final_project\\password manajer\\password manajer\\medium.png",
                "C:\\Users\\asus\\Desktop\\final_project\\password manajer\\password manajer\\strong.png",
                "C:\\Users\\asus\\Desktop\\final_project\\password manajer\\password manajer\\very_strong.png"
            };

            if (score < 1 || score > 5)
                return null;

            string imagePath = imagePaths[score - 1];
            return File.Exists(imagePath) ? System.Drawing.Image.FromFile(imagePath) : null;
        }

        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem != null)
            {
                string selectedPassword = lstHistory.SelectedItem.ToString();
                Clipboard.SetText(selectedPassword);
                statusLabel.Text = "Пароль скопійовано з історії в буфер обміну!";
            }
            else
            {
                MessageBox.Show("Оберіть пароль з історії для копіювання!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AddToHistory(string password)
        {
            lstHistory.Items.Add(password);
            File.AppendAllText(historyFile, password + Environment.NewLine);
        }

       
        private void LoadPasswordHistory()
        {
            if (File.Exists(historyFile))
            {
                string[] passwords = File.ReadAllLines(historyFile);
                lstHistory.Items.AddRange(passwords);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem != null)
            {
                lstHistory.Items.Remove(lstHistory.SelectedItem);
                File.WriteAllLines(historyFile, lstHistory.Items.Cast<string>());
                statusLabel.Text = "Пароль видалено з історії!";
            }
            else
            {
                MessageBox.Show("Оберіть пароль для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                FileName = "password_history.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, lstHistory.Items.Cast<string>());
                statusLabel.Text = "Паролі збережено у файл!";
            }
        }

      
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] passwords = File.ReadAllLines(openFileDialog.FileName);
                lstHistory.Items.Clear();
                lstHistory.Items.AddRange(passwords);
                statusLabel.Text = "Історію паролів завантажено!";
            }
        }
    }
}
