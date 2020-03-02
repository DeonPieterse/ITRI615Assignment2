using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1CS_GUI
{
    public partial class SaveForm : Form
    {
        public string fileContent { get; set; }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int SaveOption { get; set; }

        public SaveForm(int SaveOption)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.SaveOption = SaveOption;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SaveOption = 4;
            Close();
        }

        private void SaveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            SaveOption = 1;
            Close();
        }

        private void btnCiphertext_Click(object sender, EventArgs e)
        {
            SaveOption = 2;
            Close();
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            SaveOption = 3;
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
