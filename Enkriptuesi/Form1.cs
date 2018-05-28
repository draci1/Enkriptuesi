//Developed by Florijan Ibraimi (draci1)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace Enkriptuesi
{
    public partial class Form1 : Form
    {
        public int ID_Selected = 1, ID_Language=0;
        public bool encrypt = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            labelKey.Visible = textBoxKey.Visible = richAreaBoxCipher.Visible = buttonCopy.Visible = labelCopied.Visible = labelWarning1.Visible = labelWarning2.Visible = labelWarning3.Visible = buttonAL.Visible = buttonGB.Visible = LanguageBookmark.Visible = labelCipherText.Visible = false;
            buttonAL.FlatStyle = FlatStyle.Flat;
            buttonAL.FlatAppearance.BorderSize = 1;
            buttonGB.FlatStyle = FlatStyle.Flat;
            buttonGB.FlatAppearance.BorderSize = 1;
            labelTicked.Location = new Point(buttonEncrypto.Location.X, buttonDecrypto.Location.Y + buttonEncrypto.Height - labelTicked.Height);

        }
        public void ShowCipher(bool vl, string txt)
        {
            labelCipherText.Visible = vl;
            richAreaBoxCipher.Visible = vl;
            richAreaBoxCipher.Text = txt; 
            richAreaBoxCipher.Visible = vl;
            buttonCopy.Visible = vl;

        }
        public void ClearCaesar()
        {
            labelWarning1.Visible = labelKey.Visible = textBoxKey.Visible = labelWarning2.Visible = buttonAL.Visible = buttonGB.Visible = labelWarning3.Visible = LanguageBookmark.Visible = false;
        }
        public void ShowCaesar()
        {
            labelKey.Visible = textBoxKey.Visible = buttonAL.Visible = buttonGB.Visible = true;
        }
        public void ClearVigenere()
        {
            labelKey.Visible = textBoxKey.Visible = labelWarning2.Visible = false;
        }
        public void ShowVigenere()
        {
            labelKey.Visible = textBoxKey.Visible = true;
        }

        public bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public bool IsAlphabeticString(object value)
        {
            string str = value as string;
            return !string.IsNullOrWhiteSpace(str) && IsAllAlphabetic(str);
        }

        public void Reverser()
        {
            string plaintext = richTextBoxPlainText.Text;
            string ciphertext = "";
            foreach(char c in plaintext)
            {
                ciphertext = c + ciphertext;
            }
            ShowCipher(true,ciphertext);
        }

        public int FixKey(int k, int limit)
        {
            while (k > limit)
            {
                k -= limit;
            }
            return k;
        }
        public void Caesar()
        {
            int key;
            try
            {
                key = Convert.ToInt32(textBoxKey.Text);
            }
            catch(FormatException)
            {
                labelWarning2.Text = "Numbers Only!";
                labelWarning2.Visible = true;
                return;
            }
            int alphabetCount = 26;
            string plaintext = richTextBoxPlainText.Text, ciphertext = "";
            int n = 0;
            if (key < 0)
                key *= (-1);
            if (key > alphabetCount)
                key=FixKey(key, alphabetCount);
            if (encrypt == true)
            {
                foreach (char c in plaintext)
                {
                    n = (int)c;
                    if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
                    {
                        if ((n >= 65 && n <= 90 && n + key <= 90) || (n >= 97 && n <= 122 && n + key <= 122))
                        {
                            ciphertext += Convert.ToChar(n + key);
                        }
                        else ciphertext += Convert.ToChar(key - alphabetCount + n);
                    }
                    else if (ID_Language == 1 && (n == 235 || n == 203 || n == 231 || n == 199))
                        ciphertext += Convert.ToChar(n + key);
                    else ciphertext += Convert.ToChar(n);
                }
            }
            else
            {
                foreach (char c in plaintext)
                {
                    n = (int)c;
                    if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
                    {
                        if ((n >= 65 && n <= 90 && n - key >= 65) || (n >= 97 && n <= 122 && n - key >= 97))
                        {
                            ciphertext += Convert.ToChar(n - key);
                        }
                        else ciphertext += Convert.ToChar(alphabetCount + n - key);
                    }
                    else if (ID_Language == 1 && (n-key == 235 || n-key == 203 || n-key == 231 || n-key == 199))
                        ciphertext += Convert.ToChar(n - key);
                    else ciphertext += Convert.ToChar(n);
                }
            }
            ShowCipher(true, ciphertext);
        }

        public void Vigenere()
        {
            string key = textBoxKey.Text;
            if(!IsAlphabeticString(key))
            {
                labelWarning2.Text = "Non-empty\n string only!";
                labelWarning2.Visible = true;
                return;
            }
            else
            {
                int[] numkey = new int[key.Length];
                int i = 0, convnum = 0, n = 0;
                foreach (char c in key)
                {
                    if (Convert.ToInt32(c) > 96) convnum = Convert.ToInt32(c) - 96; // adjust lowercase and uppercase letters to positions starting from 1 (e.x. A is 97 and needs to convert to 1)
                    else convnum = Convert.ToInt32(c) - 64;
                    numkey[i++] = convnum;
                }
                string plaintext = richTextBoxPlainText.Text, ciphertext = "";
                if (encrypt == true)
                {
                    foreach (char l in plaintext)
                    {
                        n = (int)l;
                        if (i > numkey.Length - 1) i = 0;
                        if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
                        {
                            if ((n >= 65 && n <= 90 && n + numkey[i] <= 90) || (n >= 97 && n <= 122 && n + numkey[i] <= 122))
                            {
                                ciphertext += Convert.ToChar(n + numkey[i]);
                            }
                            else ciphertext += Convert.ToChar(numkey[i] - 26 + n);
                            i++;

                        }
                        else ciphertext += l;
                    }
                }
                else
                {
                    foreach (char l in plaintext)
                    {
                        n = (int)l;
                        if (i > numkey.Length - 1) i = 0;
                        if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
                        {
                            if ((n >= 65 && n <= 90 && n - numkey[i] >= 65) || (n >= 97 && n <= 122 && n - numkey[i] >= 97))
                            {
                                ciphertext += Convert.ToChar(n - numkey[i]);
                            }
                            else ciphertext += Convert.ToChar(26 + n - numkey[i]);
                            i++;

                        }
                        else ciphertext += l;
                    }
                }
                
                ShowCipher(true, ciphertext);
            }
        }

        public void OTP()
        {
            string teksti = richTextBoxPlainText.Text; // teksti i cili ka me u enkodu
            string qelesi = textBoxKey.Text; // qelesi apo ciper key
            if (encrypt == true)
            {
                ShowCipher(true, OneTimePad.Encode(teksti, qelesi)); // enkodo apo enkripto tekstin
            }
            else ShowCipher(true,OneTimePad.Decode(teksti, qelesi)); // dekodo apo dekripto tekstin. Kujdes qelesi duhet te jete i njejt 
        }

        private void buttonReverser_Click(object sender, EventArgs e)
        {
            YellowBookMark.Top = buttonReverser.Top;
            ShowCipher(false,"");
            ID_Selected = 1;
            ClearVigenere();
            ClearCaesar();
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
        }

        private void buttonCaesar_Click(object sender, EventArgs e)
        {
            YellowBookMark.Top = buttonCaesar.Top;
            ID_Selected = 2;
            ShowCipher(false, "");
            labelWarning1.Visible = false;
            ClearVigenere();
            ShowCaesar();
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
        }

        private void buttonVigenere_Click(object sender, EventArgs e)
        {
            YellowBookMark.Top = buttonVigenere.Top;
            ID_Selected = 3;
            ShowCipher(false, "");
            labelWarning1.Visible = false;
            ClearCaesar();
            ShowVigenere();
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
        }

        private void buttonOTP_Click(object sender, EventArgs e)
        {
            YellowBookMark.Top = buttonOTP.Top;
            ID_Selected = 4;
            ShowCipher(false, "");
            labelWarning1.Visible = false;
            ClearCaesar();
            ShowVigenere();
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(richTextBoxPlainText.Text) || ID_Selected == 2 && String.IsNullOrWhiteSpace(textBoxKey.Text) || (ID_Selected == 2 && ID_Language == 0)){
                if (String.IsNullOrWhiteSpace(richTextBoxPlainText.Text))
                    labelWarning1.Visible = true;
                if (ID_Selected == 2 && String.IsNullOrWhiteSpace(textBoxKey.Text))
                    labelWarning2.Visible = true;
                if (ID_Selected == 2 && ID_Language == 0)
                    labelWarning3.Visible = true;
            }
            else switch (ID_Selected)
                {
                    case 1:
                        Reverser();
                        break;
                    case 2:
                        Caesar();
                        break;
                    case 3:
                        Vigenere();
                        break;
                    case 4:
                        OTP();
                        break;
                    default:
                        MessageBox.Show("Oops! Something went wrong. Notify the developer and describe him what you did prior to this message.");
                        break;
                }
        }

        private void richTextBoxPlainText_TextChanged(object sender, EventArgs e)
        {
            labelWarning1.Visible = false;
            labelCopied.Visible = false;
            ShowCipher(false, "");
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            labelWarning2.Visible = false;
            ShowCipher(false, "");
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richAreaBoxCipher.Text);
            labelCopied.Visible = true;
        }

        private void buttonAL_Click(object sender, EventArgs e)
        {
            ID_Language = 1;
            labelWarning3.Visible = false;
            LanguageBookmark.Visible = true;
            LanguageBookmark.Location = new Point(buttonAL.Location.X+buttonAL.Width,buttonAL.Location.Y);
        }

        private void buttonEncrypto_Click(object sender, EventArgs e)
        {
            encrypt = true;
            labelTicked.Location = new Point(buttonEncrypto.Location.X , buttonDecrypto.Location.Y + buttonEncrypto.Height - labelTicked.Height);
            labelPlainText.Text = "Plain Text:";
            buttonEncrypt.Text = "Encrypt";
            labelCipherText.Text = "Cipher Text:";
            labelWarning1.Visible = labelWarning2.Visible = labelWarning3.Visible = false;
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
            labelCopied.Visible = false;
            ShowCipher(false, "");

        }

        private void buttonDecrypto_Click(object sender, EventArgs e)
        {
            encrypt = false;
            labelTicked.Location = new Point(buttonDecrypto.Location.X +buttonDecrypto.Width - labelTicked.Width,buttonDecrypto.Location.Y + buttonDecrypto.Height - labelTicked.Height);
            labelPlainText.Text = "Cipher Text:";
            buttonEncrypt.Text = "Decrypt";
            labelCipherText.Text = "Plain Text:";
            labelWarning1.Visible = labelWarning2.Visible = labelWarning3.Visible = false;
            richTextBoxPlainText.Text = "";
            textBoxKey.Text = "";
            labelCopied.Visible = false;
            ShowCipher(false, "");
        }

        private void buttonGB_Click(object sender, EventArgs e)
        {
            ID_Language = 2;
            labelWarning3.Visible = false;
            LanguageBookmark.Visible = true;
            LanguageBookmark.Location = new Point(buttonGB.Location.X + buttonGB.Width, buttonGB.Location.Y);
        }
    }


    class OneTimePad
    {
        //karakteret e perzgjedhura
        private static string _b64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijk.mnopqrstuvwxyz-123456789+/=";

        public static string Encode(string data, string key)
        {
            int keypos = 0;
            string binarydata = "";

            foreach (char c in data)
            {
                int xor = ((int)c ^ (int)key[keypos]) + (key.Length);
                // Console.WriteLine("{0} = {1}\t{2} = {3}: {4} = {5}", c, (int)c, key[keypos], (int)key[keypos], xor, DecToBinary(xor, 8));
                if (++keypos >= key.Length)
                    keypos = 0;

                binarydata += DecToBinary(xor, 8);
            }

            int m = 0;
            string cipher = "";

            for (int i = 0; i < binarydata.Length; i += 4)
            {
                int v = BinToDec(binarydata.Substring(i, 4));
                cipher += GetB64FromN(v * 4 + m);
                // Console.WriteLine("{0}\t{1}\t{2} {3}", v, v * 4 + m, m, GetB64FromN(v * 4 + m)[0]);
                if (++m > 3)
                    m = 0;
            }
            return cipher;
        }

        public static string Decode(string data, string key)
        {
            int m = 0;
            string binarydata = "";

            foreach (char c in data)
            {
                int v = (GetNFromB64(c) - m) / 4;
                binarydata += DecToBinary(v, 4);
                //   Console.WriteLine("{0}", DecToBinary(v, 4));
                if (++m > 3)
                    m = 0;
            }

            // chop the 8bit binaries and mix back the key into it
            int keypos = 0;
            string decoded = "";
            for (int i = 0; i < binarydata.Length; i += 8)
            {
                if (i + 8 > binarydata.Length)
                    break;
                int c = BinToDec(binarydata.Substring(i, 8));
                int dc = (c - key.Length) ^ (int)key[keypos];
                //   Console.WriteLine("{0} = {1}", binarydata.Substring(i, 8), c);
                //   Console.WriteLine("               {0} - {1} ^ {2} = {3}", c, key.Length - 1, (int)key[keypos], (c - key.Length) ^ (int)key[keypos]);

                if (++keypos >= key.Length)
                    keypos = 0;

                decoded += new string((char)dc, 1);
            }
            return decoded;
        }


        private static int GetNFromB64(char n)
        {
            return _b64.IndexOf(n);
        }


        private static string GetB64FromN(int n)
        {
            if (n > _b64.Length)
                return "=";

            return new string(_b64[n], 1);
        }


        private static string DecToBinary(int value, int length)
        {

            string binString = "";

            while (value > 0)
            {
                binString += value % 2;
                value /= 2;
            }


            string reverseString = "";
            foreach (char c in binString)
                reverseString = new string((char)c, 1) + reverseString;
            binString = reverseString;


            binString = new string((char)'0', length - binString.Length) + binString;

            return binString;
        }


        private static int BinToDec(string Binary)
        {
            return Convert.ToInt32(Binary, 2);
        }
    }

}
