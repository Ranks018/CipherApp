namespace ceaserCipher101
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            vKeyTextbox.Enabled = false;
            UpdateButtons();
        }

        private string CipherText(string text, int caesarKey, string vigenereKey, bool encrypt = true)
        {
            if (radioCaesar_Btn.Checked)
            {

                string result = "";
                int adjustedKey = encrypt ? caesarKey : -caesarKey;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        int baseChar = char.IsUpper(c) ? 'A' : 'a';
                        int newCharValue = ((c - baseChar) + adjustedKey + 26) % 26 + baseChar;
                        result += (char)newCharValue;
                    }
                    else
                    {
                        result += c;
                    }
                }

                return result;
            }
            else if (radioVigenere_Btn.Checked)
            {

                string result = "";
                string key = vigenereKey.ToLower();
                int keyIndex = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        int baseChar = char.IsUpper(c) ? 'A' : 'a';
                        int shift = key[keyIndex % key.Length] - 'a';
                        int newCharValue = ((c - baseChar) + (encrypt ? shift : -shift) + 26) % 26 + baseChar;
                        result += (char)newCharValue;
                        keyIndex++;
                    }
                    else
                    {
                        result += c;
                    }
                }

                return result;
            }
            else
            {
                return text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string plainText = plainTextBx.Text;
            int caesarKey = (int)numericUpDown_btn.Value;
            string vigenereKey = vKeyTextbox.Text;
            string encryptedText = CipherText(plainText, caesarKey, vigenereKey);

            encryptDecryptTextBx.Text = encryptedText;
            encryptDecryptTextBx.ForeColor = Color.Red;

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string encryptedText = plainTextBx.Text;
            int caesarKey = (int)numericUpDown_btn.Value;
            string vigenereKey = vKeyTextbox.Text;
            string plainText = CipherText(encryptedText, caesarKey, vigenereKey, encrypt: false);

            encryptDecryptTextBx.Text = plainText;
            encryptDecryptTextBx.ForeColor = Color.Green;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            plainTextBx.Clear();
            encryptDecryptTextBx.Clear();
            if (plainTextBx.Text == "")
            {

                plainTextBx.Text = "Enter Plain Text Here";
                plainTextBx.ForeColor = Color.Silver;
            }

            if (encryptDecryptTextBx.Text == "")
            {

                encryptDecryptTextBx.Text = "Encrypted/Decrypted Text";
                encryptDecryptTextBx.ForeColor = Color.Silver;
            }

        }

        private void plainTextEnter(object sender, EventArgs e)
        {
            if (plainTextBx.Text == "Enter Plain Text Here")
            {
                plainTextBx.Clear();
                plainTextBx.ForeColor = Color.Black;
            }

        }

        private void plainTextLeave(object sender, EventArgs e)
        {
            if (plainTextBx.Text == "")
            {
                plainTextBx.Text = "Enter Plain Text Here";
                plainTextBx.ForeColor = Color.Silver;
            }
        }

        private void encryptDecryptTextBx_Enter(object sender, EventArgs e)
        {
            if (encryptDecryptTextBx.Text == "Encrypted/Decrypted Text")
            {
                encryptDecryptTextBx.Clear();
                encryptDecryptTextBx.ForeColor = Color.Black;
            }
        }

        private void encryptDecryptTextBx_Leave(object sender, EventArgs e)
        {
            if (encryptDecryptTextBx.Text == "")
            {
                encryptDecryptTextBx.Text = "Encrypted/Decrypted Text";
                encryptDecryptTextBx.ForeColor = Color.Silver;
            }
        }

        private void plainTextBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }


        private void radioCaesar_Btn_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_btn.Enabled = radioCaesar_Btn.Checked;
            vKeyTextbox.Enabled = !radioCaesar_Btn.Checked;
            label1.Visible = !radioCaesar_Btn.Checked;
            UpdateButtons();
        }

        private void radioVigenere_Btn_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_btn.Enabled = !radioVigenere_Btn.Checked;
            vKeyTextbox.Enabled = radioVigenere_Btn.Checked;
            label2.Visible = !radioVigenere_Btn.Checked;
            UpdateButtons();
        }

        private void vKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();

        }
        private void UpdateButtons()
        {
            if (radioVigenere_Btn.Checked && string.IsNullOrEmpty(vKeyTextbox.Text))
            {
                encryptBtn.Enabled = false;
                decryptBtn.Enabled = false;
            }
            else
            {
                encryptBtn.Enabled = true;
                decryptBtn.Enabled = true;
            }
        }

        private void vKeyTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
