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

namespace Assignment1CS_GUI
{
    public partial class Files : Form
    {
        public string fileContent { get; set; }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private RichTextBox txtInput;
        private RichTextBox txtOutput;
        private RichTextBox txtKey;
        private Label lblInput;
        private Label lblOutput;
        private OpenFileDialog file;

        public Files(RichTextBox txtInput, RichTextBox txtOutput, RichTextBox txtKey, Label lblInput, Label lblOutput, OpenFileDialog file)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.txtInput = txtInput;
            this.txtOutput = txtOutput;
            this.txtKey = txtKey;
            this.lblInput = lblInput;
            this.lblOutput = lblOutput;
            this.file = file;
        }

        private void Files_Load(object sender, EventArgs e)
        {

            if (file.FileName.Contains(".ct"))
            {
                txtOutput.Text = fileContent;
                lblOutput.Text = file.FileName;
                Close();
            }
            else if (file.FileName.Contains(".pk"))
            {
                txtKey.Text = fileContent;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtInput.Text = fileContent;
            lblInput.Text = file.FileName;
            Close();
        }

        private void btnCiphertext_Click(object sender, EventArgs e)
        {
            txtOutput.Text = fileContent;
            lblOutput.Text = file.FileName;
            Close();
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            txtKey.Text = fileContent;
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
