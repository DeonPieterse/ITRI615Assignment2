namespace Assignment1CS_GUI
{
    partial class SaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.btnCiphertext = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnClearText = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Aqua;
            this.btnCancel.Location = new System.Drawing.Point(337, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPrivateKey);
            this.panel1.Controls.Add(this.btnCiphertext);
            this.panel1.Controls.Add(this.lblSave);
            this.panel1.Controls.Add(this.btnClearText);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 172);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrivateKey.FlatAppearance.BorderSize = 0;
            this.btnPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivateKey.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateKey.ForeColor = System.Drawing.Color.Aqua;
            this.btnPrivateKey.Image = ((System.Drawing.Image)(resources.GetObject("btnPrivateKey.Image")));
            this.btnPrivateKey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrivateKey.Location = new System.Drawing.Point(301, 83);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(137, 86);
            this.btnPrivateKey.TabIndex = 20;
            this.btnPrivateKey.Text = "Private Key";
            this.btnPrivateKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrivateKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // btnCiphertext
            // 
            this.btnCiphertext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCiphertext.FlatAppearance.BorderSize = 0;
            this.btnCiphertext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiphertext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiphertext.ForeColor = System.Drawing.Color.Aqua;
            this.btnCiphertext.Image = ((System.Drawing.Image)(resources.GetObject("btnCiphertext.Image")));
            this.btnCiphertext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCiphertext.Location = new System.Drawing.Point(158, 83);
            this.btnCiphertext.Name = "btnCiphertext";
            this.btnCiphertext.Size = new System.Drawing.Size(116, 86);
            this.btnCiphertext.TabIndex = 19;
            this.btnCiphertext.Text = "Ciphertext";
            this.btnCiphertext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCiphertext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCiphertext.UseVisualStyleBackColor = true;
            this.btnCiphertext.Click += new System.EventHandler(this.btnCiphertext_Click);
            // 
            // lblSave
            // 
            this.lblSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.Aqua;
            this.lblSave.Location = new System.Drawing.Point(14, 13);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(139, 30);
            this.lblSave.TabIndex = 18;
            this.lblSave.Text = "Save the...";
            // 
            // btnClearText
            // 
            this.btnClearText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearText.FlatAppearance.BorderSize = 0;
            this.btnClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText.ForeColor = System.Drawing.Color.Aqua;
            this.btnClearText.Image = ((System.Drawing.Image)(resources.GetObject("btnClearText.Image")));
            this.btnClearText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearText.Location = new System.Drawing.Point(3, 83);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(116, 86);
            this.btnClearText.TabIndex = 17;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(443, 174);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.Button btnCiphertext;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnClearText;
    }
}