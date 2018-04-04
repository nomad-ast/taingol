using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;

namespace taingol
{
    public partial class step6 : Form
    {
        public bool isEnableGB = false;
        public step6()
        {
            InitializeComponent();
        }
        byte[] encrypted;
        string hash_enc_B;
        BigInteger Sign;
        Aes myAes = Aes.Create();
        private void button12_Click(object sender, EventArgs e)
        {
            

            /*for (int i = 0; i < 32; i++)
                aes_key.Text += (myAes.Key[i]).ToString();*/
            aes_key.Text = BitConverter.ToString(myAes.Key);

        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                
                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
               using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string original = textBox2.Text;
         
            encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
            //string hex = BitConverter.ToString(encrypted);
            //for (int i = 0; i < encrypted.Length; i++)
            enc_txt.Text = BitConverter.ToString(encrypted);
            Form1.key_enc_B = myAes.Key;
            Form1.IV_enc_B = myAes.IV;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            hash_enc_B = Form1.GetMd5Hash(md5Hash, enc_txt.Text);
            hash_extB_txt.Text = hash_enc_B;
        }

        

        private void button4_Click(object sender, EventArgs e) 
        {
            
            //подпись хэша
            
            Sign = BigInteger.Parse(hash_extB_txt.Text, System.Globalization.NumberStyles.HexNumber);//берет абсолютное значение
            if (Sign < 0)
            {
                Sign = BigInteger.Abs(Sign);
            }
            Sign = BigInteger.ModPow(Sign, Form1.d2, Form1.n2);
            sign_hash_txt.Text = Sign.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.enc_B = encrypted;   //зашифрованная AES бюллетень
            Form1.sign_B = BigInteger.Parse(sign_hash_txt.Text);     //подписанный хэш
            Form1.hash_B = BigInteger.Abs(BigInteger.Parse(hash_extB_txt.Text, System.Globalization.NumberStyles.HexNumber));
            step6 fm = new step6();
            this.Hide();
            isEnableGB = true;
            //Form1.en1();
        }
    }
}
