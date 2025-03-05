namespace ceaserCipher101
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
            plainTextBx = new TextBox();
            encryptBtn = new Button();
            clearBtn = new Button();
            decryptBtn = new Button();
            encryptDecryptTextBx = new TextBox();
            numericUpDown_btn = new NumericUpDown();
            label1 = new Label();
            radioCaesar_Btn = new RadioButton();
            radioVigenere_Btn = new RadioButton();
            vKeyTextbox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_btn).BeginInit();
            SuspendLayout();
            // 
            // plainTextBx
            // 
            plainTextBx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plainTextBx.ForeColor = SystemColors.ScrollBar;
            plainTextBx.Location = new Point(244, 112);
            plainTextBx.Multiline = true;
            plainTextBx.Name = "plainTextBx";
            plainTextBx.Size = new Size(408, 44);
            plainTextBx.TabIndex = 0;
            plainTextBx.Text = "Enter Plain Text Here";

            plainTextBx.Enter += plainTextEnter;
            plainTextBx.KeyDown += plainTextBx_KeyDown;
            plainTextBx.Leave += plainTextLeave;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(244, 239);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(75, 23);
            encryptBtn.TabIndex = 1;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(407, 312);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(577, 239);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(75, 23);
            decryptBtn.TabIndex = 3;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // encryptDecryptTextBx
            // 
            encryptDecryptTextBx.BackColor = SystemColors.ButtonHighlight;
            encryptDecryptTextBx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encryptDecryptTextBx.ForeColor = Color.Silver;
            encryptDecryptTextBx.Location = new Point(244, 189);
            encryptDecryptTextBx.Multiline = true;
            encryptDecryptTextBx.Name = "encryptDecryptTextBx";
            encryptDecryptTextBx.ReadOnly = true;
            encryptDecryptTextBx.Size = new Size(408, 44);
            encryptDecryptTextBx.TabIndex = 4;
            encryptDecryptTextBx.Text = "Encrypted/Decrypted Text";

            encryptDecryptTextBx.Enter += encryptDecryptTextBx_Enter;
            encryptDecryptTextBx.Leave += encryptDecryptTextBx_Leave;
            // 
            // numericUpDown_btn
            // 
            numericUpDown_btn.Location = new Point(552, 68);
            numericUpDown_btn.Name = "numericUpDown_btn";
            numericUpDown_btn.Size = new Size(100, 23);
            numericUpDown_btn.TabIndex = 5;
            numericUpDown_btn.Value = new decimal(new int[] { 3, 0, 0, 0 });

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 49);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "KEY";
            label1.Visible = false;
            // 
            // radioCaesar_Btn
            // 
            radioCaesar_Btn.AutoSize = true;
            radioCaesar_Btn.Checked = true;
            radioCaesar_Btn.Location = new Point(12, 32);
            radioCaesar_Btn.Name = "radioCaesar_Btn";
            radioCaesar_Btn.Size = new Size(98, 19);
            radioCaesar_Btn.TabIndex = 7;
            radioCaesar_Btn.TabStop = true;
            radioCaesar_Btn.Text = "Caesar Cipher";
            radioCaesar_Btn.UseVisualStyleBackColor = true;
            radioCaesar_Btn.CheckedChanged += radioCaesar_Btn_CheckedChanged;
            // 
            // radioVigenere_Btn
            // 
            radioVigenere_Btn.AutoSize = true;
            radioVigenere_Btn.Location = new Point(12, 67);
            radioVigenere_Btn.Name = "radioVigenere_Btn";
            radioVigenere_Btn.Size = new Size(109, 19);
            radioVigenere_Btn.TabIndex = 8;
            radioVigenere_Btn.Text = "Vigenere Cipher";
            radioVigenere_Btn.UseVisualStyleBackColor = true;
            radioVigenere_Btn.CheckedChanged += radioVigenere_Btn_CheckedChanged;
            // 
            // vKeyTextbox
            // 
            vKeyTextbox.Location = new Point(244, 67);
            vKeyTextbox.Name = "vKeyTextbox";
            vKeyTextbox.Size = new Size(100, 23);
            vKeyTextbox.TabIndex = 9;
            vKeyTextbox.TextChanged += vKeyTextbox_TextChanged;
            vKeyTextbox.KeyPress += vKeyTextbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 50);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 10;
            label2.Text = "KEY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(911, 540);
            Controls.Add(label2);
            Controls.Add(vKeyTextbox);
            Controls.Add(radioVigenere_Btn);
            Controls.Add(radioCaesar_Btn);
            Controls.Add(label1);
            Controls.Add(numericUpDown_btn);
            Controls.Add(encryptDecryptTextBx);
            Controls.Add(decryptBtn);
            Controls.Add(clearBtn);
            Controls.Add(encryptBtn);
            Controls.Add(plainTextBx);
            Name = "Form1";
            Text = "Cipher App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox plainTextBx;
        private Button encryptBtn;
        private Button clearBtn;
        private Button decryptBtn;
        private TextBox encryptDecryptTextBx;
        private NumericUpDown numericUpDown_btn;
        private Label label1;
        private RadioButton radioCaesar_Btn;
        private RadioButton radioVigenere_Btn;
        private TextBox vKeyTextbox;
        private Label label2;
    }
}
