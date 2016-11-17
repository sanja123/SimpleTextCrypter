using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
namespace TextCrypterCSWF
{
    public partial class MainForm : Form
    {

        const int AsciiConvertConstant = 96;
        public MainForm()
        {
            InitializeComponent();
            LBPassword.BackColor = Color.Transparent;
            LBbias.BackColor = Color.Transparent;
            LBbias.ForeColor = Color.White;
            LBPassword.ForeColor = Color.White;
            CBencoding.SelectedIndex = 1;
            
        }

        private void CryptBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBInput.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Pasword or Input are empty");
                return;
            }
            if ((CBencoding.SelectedItem.ToString()).ToLower().Contains("ascii"))
                EncryptByAscii();
            else if ((CBencoding.SelectedItem.ToString()).ToLower().Contains("unicode"))
                EncryptByUnicode();
            this.Validate();
        }

        private void EncryptByUnicode()
        {
            MessageBox.Show("Not ready yet! Use ascii");
        }

        private void EncryptByAscii()
        {
            var sbuilder = new StringBuilder();
            string input = TBInput.Text.ToLower();
            string password = PasswordBox.Text.ToLower();
            int j = 0;
            for (int i = 0; i < input.Length -1; i++)
            {
                if (input[i] == ' ')
                {
                    sbuilder.Append(".");
                    continue;
                }
                var value = (input[i] - AsciiConvertConstant) + (password[j] - AsciiConvertConstant) - 1;
      //          if (value > 30)
      //              value -= 30;
                var encryptedValue = value + (int)BiasNUD.Value;
                sbuilder.Append(encryptedValue.ToString());
                sbuilder.Append(".");
                if (++j >= password.Length)
                    j = 0;
            }
            TBOutput.Text = sbuilder.ToString();
        }

        private void BTNDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBInput.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Pasword or Input are empty");
                return;
            }
            var sbuilder = new StringBuilder();
            string input = TBInput.Text.ToLower();
            string password = PasswordBox.Text.ToLower();
            int j = 0;
            int pasl = password.Length-1;
            int bias = (int)BiasNUD.Value;
            var words = new List<string>();
            var NumbericWords = new List<List<int>>();
            while (input.Contains(".."))
            {
                var word = input.Substring(0,input.IndexOf(".."));
                input = input.Substring(input.IndexOf("..")+2);
                words.Add(word);
            }
            words.Add(input);
            foreach (var word in words)
            {
                var lettersN = new List<int>();
                var lettersC = word.Split('.');
                foreach (string letterC in lettersC)
                {
                    if (string.IsNullOrEmpty(letterC))
                        continue;
                    var letterN = int.Parse(letterC);
                    lettersN.Add(letterN);
                }
                NumbericWords.Add(lettersN);
            }
            foreach (var word in NumbericWords)
            {
                foreach (var letter in word)
                {
                    var value = (letter - bias + 1 - (password[j++] - AsciiConvertConstant)) + AsciiConvertConstant;
                    if (j > pasl)
                        j = 0;
                    sbuilder.Append((char)value);
                }
                sbuilder.Append(" ");
            }
            TBOutput.Text = sbuilder.ToString();
            Validate();
        }
    }
}
