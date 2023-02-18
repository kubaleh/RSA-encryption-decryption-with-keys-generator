//https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.rsacryptoserviceprovider?redirectedfrom=MSDN&view=net-7.0
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuperAdminSecureSend
{
    public partial class Form1 : Form
    {
        string publicKeyPath = "publicKey.xml";
        string privateKeyPath = "privateKey.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void btngen_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                string publicKeyXml = RSA.ToXmlString(false);
                string privateKeyXml = RSA.ToXmlString(true);
                string _publicKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicKeyXml));
                string _privateKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(privateKeyXml));
                TextWriter writer = new StreamWriter("publicKey.xml");
                string publicKey = RSA.ToXmlString(false);
                writer.Write(publicKey);
                writer.Close();
                writer = new StreamWriter("privateKey.xml");
                string privateKey = RSA.ToXmlString(true);
                writer.Write(privateKey);
                writer.Close();
            }
        }
        private void btnencrypt_Click(object sender, EventArgs e)
        {
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(txtInput.Text.ToString());
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                TextReader reader = new StreamReader(publicKeyPath);
                string publicKey = reader.ReadToEnd();
                reader.Close();
                RSA.FromXmlString(publicKey);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
            txtOutput.Text = Convert.ToBase64String(encryptedData);
        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {
            byte[] decryptedData;
            byte[] dataToDecrypt = Convert.FromBase64String(txtInput.Text.ToString());
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                TextReader reader = new StreamReader(privateKeyPath);
                string privateKey = reader.ReadToEnd();
                reader.Close();

                RSA.FromXmlString(privateKey);
                decryptedData = RSA.Decrypt(dataToDecrypt, false);
            }
            txtOutput.Text = Encoding.UTF8.GetString(decryptedData);
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Select File";
            chooseFile.InitialDirectory = @"C:\";
            chooseFile.Filter = "*.xml|";
            chooseFile.FilterIndex = 2;
            chooseFile.ShowDialog();
            if (chooseFile.FileName != "")
            {
                textBox1.Text = chooseFile.FileName;
                privateKeyPath = chooseFile.FileName.ToString();
            }
            else
                textBox1.Text = "You didn't select the file!";
        }

        private void btnPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Select File";
            chooseFile.InitialDirectory = @"C:\";
            chooseFile.Filter = "*.xml|";
            chooseFile.FilterIndex = 2;
            chooseFile.ShowDialog();
            if (chooseFile.FileName != "")
            {
                textBox2.Text = chooseFile.FileName;
                publicKeyPath = chooseFile.FileName.ToString();
            }
            else
                textBox1.Text = "You didn't select the file!";
        }

        private void btngen_Click_1(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                string publicKeyXml = RSA.ToXmlString(false);
                string privateKeyXml = RSA.ToXmlString(true);
                string _publicKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicKeyXml));
                string _privateKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(privateKeyXml));
                TextWriter writer = new StreamWriter("publicKey.xml");
                string publicKey = RSA.ToXmlString(false);
                writer.Write(publicKey);
                writer.Close();
                writer = new StreamWriter("privateKey.xml");
                string privateKey = RSA.ToXmlString(true);
                writer.Write(privateKey);
                writer.Close();
            }
        }
    }
}
