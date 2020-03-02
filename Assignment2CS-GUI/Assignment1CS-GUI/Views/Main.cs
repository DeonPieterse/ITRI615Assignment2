using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment1CS_GUI
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public int SaveOption;

        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            saveFileDialog1.Filter = "txt files (*.txt) | *.txt | all files (*.ct, *.pk) | *.ct, *.pk";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                var val = Encrypt(txtInput.Text);
                string ciphertext = string.Concat(val.Item1);
                string privateKey = string.Concat(val.Item2);
                txtOutput.Clear();
                txtOutput.Text = ciphertext;
                txtPrivateKey.Text = privateKey;
            }
            else
            {
                lblInputDir.Text = "Failed to encrypt: No clear text given.";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                txtInput.Text = Decrypt(txtOutput.Text, txtPrivateKey.Text);
            }
            else
            {
                lblOutputDir.Text = "Failed to decrypt: No ciphertext given.";
            }
        }

        public Tuple<string[], string[]> Encrypt(string clearText)
        {
            char[] charArray = clearText.ToCharArray();
            string[] privateKey = new string[charArray.Length];
            string[] cipherText = new string[charArray.Length];

            Random random = new Random();

            for (int i = 0; i < charArray.Length; i++)
            {

                char rand = (char)random.Next(33, 48);
                int randNum = random.Next(97, 122);
                cipherText[i] = (Convert.ToInt64(charArray[i]) + i + randNum).ToString() + (char)random.Next(33, 48);
                privateKey[i] = Convert.ToChar(randNum) + rand.ToString();

            }

            success();
            return Tuple.Create(cipherText, privateKey);
        }

        public string Decrypt(string cipherText, string privateKey)
        {
            string numPattern = @"\D+";
            string charPattern = @"[^a-zA-Z]";

            // Strings of all numbers in array without special characters
            string[] numbersFromClearText = Regex.Split(cipherText, numPattern);

            // Strings of all ascii characters
            //long[] privateKeyDeductions = Regex.Split(privateKey, charPattern).Select(long.Parse).ToArray();
            string[] privateKeyDeductions = Regex.Split(privateKey, charPattern).ToArray();

            // Removes all the null values in the array
            string[] numbersFromClearTextWithoutNulls = RemoveNulls(numbersFromClearText);

            // Removes all the null values in the array
            string[] privateKeyDeductionsWithoutNulls = RemoveNulls(privateKeyDeductions);

            // all numbers in numbersFromClearText converted to ints
            long[] numberSegments = Array.ConvertAll(numbersFromClearTextWithoutNulls, long.Parse);
            char[] decryptedSegments = new char[numbersFromClearTextWithoutNulls.Length];

            if (numberSegments.Length != privateKeyDeductionsWithoutNulls.Length && txtPrivateKey.Text != "")
            {
                lblOutputDir.Text = "Error: Private key incompatible with encrypted text.";

                return "";
            }

            for (int i = 0; i < privateKeyDeductionsWithoutNulls.Length; i++)
            {
                decryptedSegments[i] = (char)(numberSegments[i] - Convert.ToChar(privateKeyDeductionsWithoutNulls[i]) - i);
            }

            success();
            return string.Concat(decryptedSegments);
        }

        //public T[] RemoveNulls<T>(T[] arrayToAlter)
        //{
        //    return arrayToAlter.Where(e => !string.IsNullOrEmpty(e.ToString()) || e != null ).ToArray();
        //}

        public string[] RemoveNulls(string[] arrayToAlter)
        {
            return arrayToAlter.Where(e => !string.IsNullOrEmpty(e.ToString())).ToArray();
        }

        public void success()
        {
            panSuccess.Visible = true;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                    openFileDialog1.CheckFileExists == true)
            {
                Files fileWindow = new Files(txtInput, txtOutput, txtPrivateKey, lblInputDir, lblOutputDir, openFileDialog1);
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    fileWindow.fileContent = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Details: " + exc.StackTrace + "\n\nError message: " + exc.Message);
                }
                finally
                {
                    fileWindow.ShowDialog();
                }
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            SaveForm saveForm = new SaveForm(SaveOption);
            saveForm.ShowDialog();

            string saveContent = "";

            if (saveForm.SaveOption == 1)
            {
                saveContent = txtInput.Text;
                saveFileDialog1.FileName = "ClearText.txt";
            }
            else if (saveForm.SaveOption == 2)
            {
                saveContent = txtOutput.Text;
                saveFileDialog1.FileName = "CipherText.ct";
            }
            else if (saveForm.SaveOption == 3)
            {
                saveContent = txtPrivateKey.Text;
                saveFileDialog1.FileName = "PrivateKey.pk";
            }
            else
            {
                return;
            }

            if (saveContent == "")
            {
                if (saveForm.SaveOption == 1)
                    lblInputDir.Text = "Failed to save: Clear text field was empty...";
                else if (saveForm.SaveOption == 2)
                    lblOutputDir.Text = "Failed to save: Chiphertext field was empty...";
                else if (saveForm.SaveOption == 3)
                    lblOutputDir.Text = "Failed to save: Private key field was empty...";
                return;
            }


            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(saveContent);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnClearText_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtPrivateKey.Clear();
            lblInputDir.ResetText();
            lblOutputDir.ResetText();
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text != null)
            {
                var val = Encrypt(txtInput.Text);
                string ciphertext = string.Concat(val.Item1);
                string privateKey = string.Concat(val.Item2);
                txtOutput.Clear();
                txtOutput.Text = ciphertext;
                txtPrivateKey.Text = privateKey;
            }
        }

        private void txtOutput_Enter(object sender, EventArgs e)
        {
            if (txtOutput.Text != null)
            {
                txtInput.Text = Decrypt(txtOutput.Text, txtPrivateKey.Text);
            }
        }

        private void lblInputDir_Click(object sender, EventArgs e)
        {

        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblClearTextCount.Text = txtInput.Text.Length.ToString();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            lblCipherTextCount.Text = txtOutput.Text.Length.ToString();
        }

        private void panSuccess_MouseMove(object sender, MouseEventArgs e)
        {
            panSuccess.Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
