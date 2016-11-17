namespace TextCrypterCSWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TBInput = new System.Windows.Forms.TextBox();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.LBPassword = new System.Windows.Forms.Label();
            this.LBbias = new System.Windows.Forms.Label();
            this.BTNEncrypt = new System.Windows.Forms.Button();
            this.BTNDecrypt = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.BiasNUD = new System.Windows.Forms.NumericUpDown();
            this.CBencoding = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BiasNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TBInput.Location = new System.Drawing.Point(12, 72);
            this.TBInput.Multiline = true;
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(180, 194);
            this.TBInput.TabIndex = 0;
            // 
            // TBOutput
            // 
            this.TBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TBOutput.Location = new System.Drawing.Point(359, 72);
            this.TBOutput.Multiline = true;
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(180, 194);
            this.TBOutput.TabIndex = 1;
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPassword.Location = new System.Drawing.Point(13, 294);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(118, 19);
            this.LBPassword.TabIndex = 2;
            this.LBPassword.Text = "Enter password:";
            // 
            // LBbias
            // 
            this.LBbias.AutoSize = true;
            this.LBbias.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbias.Location = new System.Drawing.Point(13, 354);
            this.LBbias.Name = "LBbias";
            this.LBbias.Size = new System.Drawing.Size(92, 19);
            this.LBbias.TabIndex = 3;
            this.LBbias.Text = "Enter BIAS:";
            // 
            // BTNEncrypt
            // 
            this.BTNEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNEncrypt.Location = new System.Drawing.Point(198, 140);
            this.BTNEncrypt.Name = "BTNEncrypt";
            this.BTNEncrypt.Size = new System.Drawing.Size(142, 23);
            this.BTNEncrypt.TabIndex = 4;
            this.BTNEncrypt.Text = "Encrypt";
            this.BTNEncrypt.UseVisualStyleBackColor = true;
            this.BTNEncrypt.Click += new System.EventHandler(this.CryptBTN_Click);
            // 
            // BTNDecrypt
            // 
            this.BTNDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNDecrypt.Location = new System.Drawing.Point(198, 182);
            this.BTNDecrypt.Name = "BTNDecrypt";
            this.BTNDecrypt.Size = new System.Drawing.Size(142, 23);
            this.BTNDecrypt.TabIndex = 5;
            this.BTNDecrypt.Text = "Decrypt";
            this.BTNDecrypt.UseVisualStyleBackColor = true;
            this.BTNDecrypt.Click += new System.EventHandler(this.BTNDecrypt_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordBox.Location = new System.Drawing.Point(17, 326);
            this.PasswordBox.MaxLength = 10;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(128, 20);
            this.PasswordBox.TabIndex = 6;
            // 
            // BiasNUD
            // 
            this.BiasNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BiasNUD.Location = new System.Drawing.Point(17, 386);
            this.BiasNUD.Maximum = new decimal(new int[] {
            2360,
            0,
            0,
            0});
            this.BiasNUD.Name = "BiasNUD";
            this.BiasNUD.Size = new System.Drawing.Size(120, 20);
            this.BiasNUD.TabIndex = 8;
            // 
            // CBencoding
            // 
            this.CBencoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBencoding.FormattingEnabled = true;
            this.CBencoding.Items.AddRange(new object[] {
            "ASCII-addition",
            "TABLE"});
            this.CBencoding.Location = new System.Drawing.Point(209, 28);
            this.CBencoding.Name = "CBencoding";
            this.CBencoding.Size = new System.Drawing.Size(121, 21);
            this.CBencoding.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextCrypterCSWF.Properties.Resources.encryption_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 430);
            this.Controls.Add(this.CBencoding);
            this.Controls.Add(this.BiasNUD);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.BTNDecrypt);
            this.Controls.Add(this.BTNEncrypt);
            this.Controls.Add(this.LBbias);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.TBInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kula\'s Text Crypter";
            ((System.ComponentModel.ISupportInitialize)(this.BiasNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.Label LBbias;
        private System.Windows.Forms.Button BTNEncrypt;
        private System.Windows.Forms.Button BTNDecrypt;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.NumericUpDown BiasNUD;
        private System.Windows.Forms.ComboBox CBencoding;
    }
}

