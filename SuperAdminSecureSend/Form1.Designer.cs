namespace SuperAdminSecureSend
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.btnPublicKey = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(12, 28);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(637, 122);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(12, 173);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(637, 249);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // btnencrypt
            // 
            this.btnencrypt.Location = new System.Drawing.Point(655, 12);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(133, 43);
            this.btnencrypt.TabIndex = 2;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // btndecrypt
            // 
            this.btndecrypt.Location = new System.Drawing.Point(655, 61);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(133, 43);
            this.btndecrypt.TabIndex = 8;
            this.btndecrypt.Text = "Decypt";
            this.btndecrypt.UseVisualStyleBackColor = true;
            this.btndecrypt.Click += new System.EventHandler(this.btndecrypt_Click);
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(655, 110);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(133, 40);
            this.btnPrivateKey.TabIndex = 9;
            this.btnPrivateKey.Text = "Choose private key";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // btnPublicKey
            // 
            this.btnPublicKey.Location = new System.Drawing.Point(655, 156);
            this.btnPublicKey.Name = "btnPublicKey";
            this.btnPublicKey.Size = new System.Drawing.Size(133, 48);
            this.btnPublicKey.TabIndex = 10;
            this.btnPublicKey.Text = "Choose public key";
            this.btnPublicKey.UseVisualStyleBackColor = true;
            this.btnPublicKey.Click += new System.EventHandler(this.btnPublicKey_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 428);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Private Key path: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Public Key path: ";
            // 
            // btngen
            // 
            this.btngen.BackColor = System.Drawing.SystemColors.Control;
            this.btngen.Location = new System.Drawing.Point(655, 210);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(133, 49);
            this.btngen.TabIndex = 15;
            this.btngen.Text = "Generate New Keys";
            this.btngen.UseVisualStyleBackColor = false;
            this.btngen.Click += new System.EventHandler(this.btngen_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Input to encrpyt or decrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Output";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(656, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 156);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPublicKey);
            this.Controls.Add(this.btnPrivateKey);
            this.Controls.Add(this.btndecrypt);
            this.Controls.Add(this.btnencrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.Button btndecrypt;
        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.Button btnPublicKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

