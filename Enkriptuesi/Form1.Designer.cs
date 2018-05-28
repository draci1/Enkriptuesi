namespace Enkriptuesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTicked = new System.Windows.Forms.Label();
            this.buttonEncrypto = new System.Windows.Forms.Button();
            this.buttonDecrypto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.richAreaBoxCipher = new System.Windows.Forms.RichTextBox();
            this.labelCopied = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.YellowBookMark = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.richTextBoxPlainText = new System.Windows.Forms.RichTextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelWarning1 = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning3 = new System.Windows.Forms.Label();
            this.LanguageBookmark = new System.Windows.Forms.Panel();
            this.buttonGB = new System.Windows.Forms.Button();
            this.buttonAL = new System.Windows.Forms.Button();
            this.buttonVigenere = new System.Windows.Forms.Button();
            this.buttonReverser = new System.Windows.Forms.Button();
            this.buttonOTP = new System.Windows.Forms.Button();
            this.buttonCaesar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(206)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonVigenere);
            this.panel1.Controls.Add(this.buttonReverser);
            this.panel1.Controls.Add(this.buttonOTP);
            this.panel1.Controls.Add(this.buttonCaesar);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.labelTicked);
            this.panel3.Controls.Add(this.buttonEncrypto);
            this.panel3.Controls.Add(this.buttonDecrypto);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // labelTicked
            // 
            resources.ApplyResources(this.labelTicked, "labelTicked");
            this.labelTicked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(206)))));
            this.labelTicked.Name = "labelTicked";
            // 
            // buttonEncrypto
            // 
            this.buttonEncrypto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonEncrypto, "buttonEncrypto");
            this.buttonEncrypto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(206)))));
            this.buttonEncrypto.Name = "buttonEncrypto";
            this.buttonEncrypto.UseVisualStyleBackColor = true;
            this.buttonEncrypto.Click += new System.EventHandler(this.buttonEncrypto_Click);
            // 
            // buttonDecrypto
            // 
            this.buttonDecrypto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonDecrypto, "buttonDecrypto");
            this.buttonDecrypto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(206)))));
            this.buttonDecrypto.Name = "buttonDecrypto";
            this.buttonDecrypto.UseVisualStyleBackColor = true;
            this.buttonDecrypto.Click += new System.EventHandler(this.buttonDecrypto_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelCipherText);
            this.panel2.Controls.Add(this.richAreaBoxCipher);
            this.panel2.Controls.Add(this.labelCopied);
            this.panel2.Controls.Add(this.buttonCopy);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // labelCipherText
            // 
            resources.ApplyResources(this.labelCipherText, "labelCipherText");
            this.labelCipherText.ForeColor = System.Drawing.Color.White;
            this.labelCipherText.Name = "labelCipherText";
            // 
            // richAreaBoxCipher
            // 
            resources.ApplyResources(this.richAreaBoxCipher, "richAreaBoxCipher");
            this.richAreaBoxCipher.Name = "richAreaBoxCipher";
            // 
            // labelCopied
            // 
            resources.ApplyResources(this.labelCopied, "labelCopied");
            this.labelCopied.ForeColor = System.Drawing.Color.White;
            this.labelCopied.Name = "labelCopied";
            // 
            // buttonCopy
            // 
            resources.ApplyResources(this.buttonCopy, "buttonCopy");
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // YellowBookMark
            // 
            this.YellowBookMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.YellowBookMark, "YellowBookMark");
            this.YellowBookMark.Name = "YellowBookMark";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPlainText
            // 
            resources.ApplyResources(this.labelPlainText, "labelPlainText");
            this.labelPlainText.ForeColor = System.Drawing.Color.White;
            this.labelPlainText.Name = "labelPlainText";
            // 
            // richTextBoxPlainText
            // 
            resources.ApplyResources(this.richTextBoxPlainText, "richTextBoxPlainText");
            this.richTextBoxPlainText.Name = "richTextBoxPlainText";
            this.richTextBoxPlainText.TextChanged += new System.EventHandler(this.richTextBoxPlainText_TextChanged);
            // 
            // buttonEncrypt
            // 
            resources.ApplyResources(this.buttonEncrypt, "buttonEncrypt");
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxKey
            // 
            resources.ApplyResources(this.textBoxKey, "textBoxKey");
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // labelKey
            // 
            resources.ApplyResources(this.labelKey, "labelKey");
            this.labelKey.ForeColor = System.Drawing.Color.White;
            this.labelKey.Name = "labelKey";
            // 
            // labelWarning1
            // 
            resources.ApplyResources(this.labelWarning1, "labelWarning1");
            this.labelWarning1.ForeColor = System.Drawing.Color.Red;
            this.labelWarning1.Name = "labelWarning1";
            // 
            // labelWarning2
            // 
            resources.ApplyResources(this.labelWarning2, "labelWarning2");
            this.labelWarning2.ForeColor = System.Drawing.Color.Red;
            this.labelWarning2.Name = "labelWarning2";
            // 
            // labelWarning3
            // 
            resources.ApplyResources(this.labelWarning3, "labelWarning3");
            this.labelWarning3.ForeColor = System.Drawing.Color.Red;
            this.labelWarning3.Name = "labelWarning3";
            // 
            // LanguageBookmark
            // 
            this.LanguageBookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.LanguageBookmark, "LanguageBookmark");
            this.LanguageBookmark.Name = "LanguageBookmark";
            // 
            // buttonGB
            // 
            resources.ApplyResources(this.buttonGB, "buttonGB");
            this.buttonGB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonGB.FlatAppearance.BorderSize = 0;
            this.buttonGB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(130)))));
            this.buttonGB.Name = "buttonGB";
            this.buttonGB.UseVisualStyleBackColor = true;
            this.buttonGB.Click += new System.EventHandler(this.buttonGB_Click);
            // 
            // buttonAL
            // 
            resources.ApplyResources(this.buttonAL, "buttonAL");
            this.buttonAL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonAL.FlatAppearance.BorderSize = 0;
            this.buttonAL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonAL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(130)))));
            this.buttonAL.Name = "buttonAL";
            this.buttonAL.UseVisualStyleBackColor = true;
            this.buttonAL.Click += new System.EventHandler(this.buttonAL_Click);
            // 
            // buttonVigenere
            // 
            this.buttonVigenere.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonVigenere, "buttonVigenere");
            this.buttonVigenere.Name = "buttonVigenere";
            this.buttonVigenere.UseVisualStyleBackColor = true;
            this.buttonVigenere.Click += new System.EventHandler(this.buttonVigenere_Click);
            // 
            // buttonReverser
            // 
            this.buttonReverser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonReverser, "buttonReverser");
            this.buttonReverser.Name = "buttonReverser";
            this.buttonReverser.UseVisualStyleBackColor = true;
            this.buttonReverser.Click += new System.EventHandler(this.buttonReverser_Click);
            // 
            // buttonOTP
            // 
            this.buttonOTP.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonOTP, "buttonOTP");
            this.buttonOTP.Name = "buttonOTP";
            this.buttonOTP.UseVisualStyleBackColor = true;
            this.buttonOTP.Click += new System.EventHandler(this.buttonOTP_Click);
            // 
            // buttonCaesar
            // 
            this.buttonCaesar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonCaesar, "buttonCaesar");
            this.buttonCaesar.Name = "buttonCaesar";
            this.buttonCaesar.UseVisualStyleBackColor = true;
            this.buttonCaesar.Click += new System.EventHandler(this.buttonCaesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.LanguageBookmark);
            this.Controls.Add(this.labelWarning3);
            this.Controls.Add(this.buttonGB);
            this.Controls.Add(this.buttonAL);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.labelWarning1);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxPlainText);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YellowBookMark);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReverser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOTP;
        private System.Windows.Forms.Button buttonCaesar;
        private System.Windows.Forms.Panel YellowBookMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCopied;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.RichTextBox richTextBoxPlainText;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelWarning1;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.Button buttonAL;
        private System.Windows.Forms.Button buttonGB;
        private System.Windows.Forms.Label labelWarning3;
        private System.Windows.Forms.RichTextBox richAreaBoxCipher;
        private System.Windows.Forms.Panel LanguageBookmark;
        private System.Windows.Forms.Button buttonDecrypto;
        private System.Windows.Forms.Button buttonEncrypto;
        private System.Windows.Forms.Label labelTicked;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.Button buttonVigenere;
    }
}

