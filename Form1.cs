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
using System.Collections;
using System.IO;
using System.Numerics;

namespace taingol
{
    public partial class Form1 : Form
    {
        BigInteger p1 = 0, q1 = 0, n1, f1, exp1, d1;//ЦУР

        public static BigInteger p2 = 0, q2 = 0, n2, f2, exp2, d2, f_let, encr_v_x, hash_for_Epub, podp_key, sec_key,sign_B,hash_B;     //избиратель
        string hash_Epub1, hash_Epub2;                                                  //избиратель
        int x1;                                                                        //избиратель случайное число для ослепляющего шифра

        public static byte[] enc_B;
        public static byte[] key_enc_B;
        public static byte[] IV_enc_B;
        public Form1()
        {
            InitializeComponent();
        }
        static BigInteger GenerateRandomNumber(BigInteger min, BigInteger max)//генерация случайного числа
        {
            RNGCryptoServiceProvider c = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[64];
            // Массив со случайными битами
            c.GetBytes(randomNumber);
            BigInteger result = Math.Abs(BitConverter.ToInt32(randomNumber, 0));
            return result % max + min;
        }
        static BigInteger GenerateRandomNumber()//генерация случайного числа
        {
            var rng = new RNGCryptoServiceProvider();
            
            byte[] bytes = new byte[64];
            rng.GetBytes(bytes);
            BigInteger p = new BigInteger(bytes);
            p = BigInteger.Abs(p);
            return p;
        }
        static bool MillerRabinTest(BigInteger n, int k)//тест про простоту, вероятностный
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            BigInteger s = 0, d = n - 1;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;            
            }

            for (int i = 0; i < k; i++)
            {
                BigInteger a = GenerateRandomNumber(2, n - 1);  //Выбрать случайное целое число a в отрезке [2, n − 1]
                BigInteger x = BigInteger.ModPow(a, d, n); // x ← a^d mod n
                if (x == 1 || x == n - 1)  //если x = 1 или x = n − 1, то перейти на следующую итерацию цикла А
                    continue;
                for (int j = 0; j < s - 1; j++)
                {
                    x = (x * x) % n;
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }
            return true;
        }
        BigInteger GenerateBigSimpleNumber()//генерирует большое простое число 
        {
            BigInteger rand = GenerateRandomNumber();
            while (!MillerRabinTest(rand, 10))
            {
                rand = GenerateRandomNumber();
            }
            return rand;
        }
        public static BigInteger modInverse(BigInteger a, BigInteger mod)//нахождение обратного элемента для a по модулю mod
        {
            BigInteger i = mod, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= mod;
            if (v < 0) v = (v + mod) % mod;
            return v;
        }
        public static string GetMd5Hash(MD5 md5Hash, string input) //хэширование
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {


           
            

            p1 = GenerateBigSimpleNumber();
            q1 = GenerateBigSimpleNumber();
            while (p1 == q1) q1 = GenerateBigSimpleNumber();
            p_val.Text = p1.ToString();
            q_val.Text = q1.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p2 = GenerateBigSimpleNumber();
            q2 = GenerateBigSimpleNumber();
            while (p1 == q1) q1 = GenerateBigSimpleNumber();
            p2_val.Text = p2.ToString();
            q2_val.Text = q2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                p1 = BigInteger.Parse(p_val.Text);
                q1 = BigInteger.Parse(q_val.Text);
            }
            catch
            {
                MessageBox.Show("Сначала необходимо выбрать p и q", "Ошибка!");
                return;
            }
            if (MillerRabinTest(p1, 0) != true || MillerRabinTest(q1, 0) != true || q1 == p1)
            {
                MessageBox.Show("Одно из чисел не является простым или числа равны", "Ошибка");
            }
            else
            {
                /*if (textBox6.Text != "")
                {
                    Send.Visible = true;
                }*/
                n1 = BigInteger.Multiply(p1, q1);
                f1 = BigInteger.Multiply(p1 - 1, q1 - 1);

                exp1 = 0;
                for (; exp1 < f1; exp1++)
                {
                    if (MillerRabinTest(exp1, 1))
                        if (BigInteger.GreatestCommonDivisor(exp1, f1) == 1)
                            break;
                    if (exp1 == f1 - 1) exp1 = 0;
                }

                d1 = modInverse(exp1, f1);

                OpenKeySend_V.Text = "{" + exp1.ToString() + ";" + n1.ToString() + "}";
                CloseKeySend_V.Text = "{" + d1.ToString() + ";" + n1.ToString() + "}";
                //groupBox1.Location = new Point(229, 1);
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                p2 = BigInteger.Parse(p2_val.Text);
                q2 = BigInteger.Parse(q2_val.Text);
            }
            catch
            {
                MessageBox.Show("Сначала необходимо выбрать p и q", "Ошибка!");
                return;
            }
            if (MillerRabinTest(p2, 0) != true || MillerRabinTest(q2, 0) != true || q2 == p1)
            {
                MessageBox.Show("Одно из чисел не является простым или числа равны", "Ошибка");
            }
            else
            {
                /*if (textBox6.Text != "")
                {
                    Send.Visible = true;
                }*/
                n2 = BigInteger.Multiply(p2, q2);
                f2 = BigInteger.Multiply(p2 - 1, q2 - 1);

                exp2 = 0;
                for (; exp2 < f2; exp2++)
                {
                    if (MillerRabinTest(exp2, 1))
                        if (BigInteger.GreatestCommonDivisor(exp2, f2) == 1)
                            break;
                    if (exp2 == f2 - 1) exp2 = 0;
                }

                d2 = modInverse(exp2, f2);

                OpenKeySend_E.Text = "{" + exp2.ToString() + ";" + n2.ToString() + "}";  //открытый
                CloseKeySend_E.Text = "{" + d2.ToString() + ";" + n2.ToString() + "}";  //закрытый
                groupBox8.Enabled = true;
                //groupBox1.Location = new Point(229, 1);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MD5 md5Hash1 = MD5.Create();
            MD5 md5Hash2 = MD5.Create();

            hash_Epub1 = GetMd5Hash(md5Hash1, OpenKeySend_E.Text);  //вычисляем ХЭШ открытого ключа E
            //hash_Epub2 = GetMd5Hash(md5Hash2, n2.ToString());

            hash_text.Text = hash_Epub1;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            x1 = rand.Next(0, 1000);

            
            //BigInteger encr_v_x;
            //BigInteger ;
            hash_for_Epub = BigInteger.Parse(hash_text.Text, System.Globalization.NumberStyles.HexNumber);//берет абсолютное значение
            if (hash_for_Epub < 0)
            {
                hash_for_Epub = BigInteger.Abs(hash_for_Epub); 
                
            }
            label9.Text = "Случайное число = " + x1.ToString();
            encr_v_x = BigInteger.ModPow(x1, exp1, n1);
            f_let = hash_for_Epub * encr_v_x;  //вычисляем f
            f_text.Text = f_let.ToString();
            groupBox6.Enabled = true;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            BigInteger help_desh,x_dec,hash_dec;
            help_desh = BigInteger.ModPow(f_let, d1, n1); //расшифровка зашифрованного x и хеша

            x_dec = BigInteger.ModPow(encr_v_x, d1, n1);    //расшифровка зашифрованного x

            hash_dec = x_dec * BigInteger.ModPow(hash_for_Epub, d1, n1);  //x * расшифровка хеша
            g_text.Text = hash_dec.ToString();
            label16.Text = "Расшифрованный f отправлен \nизбирателю";
            groupBox7.Enabled = true;
 
        }
    
        private void button10_Click(object sender, EventArgs e)
        {
            BigInteger g_get= BigInteger.Parse(g_text.Text);
            sec_key = g_get / x1;  //снимает слой ослепляющего шифрования (умножает на обратный элемент x)
            podp_key = BigInteger.ModPow(sec_key, exp1, n1);   //получает подписанный ключ

            if (hash_for_Epub == podp_key)
                MessageBox.Show("ХЭШ и подпись регистратора - Совпадают", "Примечание");
            else
                MessageBox.Show("ХЭШ и подпись регистратора - Не совпадают", "Ошибка!");
            g_get_txt.Text = podp_key.ToString();  // на этом этап регистрации заканчивается
        }

        private void button9_Click(object sender, EventArgs e)
        {
            get_pair.Text = "{" + exp2.ToString() + ";" + n2.ToString() + "}" + "{" + sec_key.ToString() + "}";  //открытый
            groupBox9.Enabled=true;
        }
       
        private void button11_Click(object sender, EventArgs e)
        {
            BigInteger check_sim = BigInteger.ModPow(sec_key, exp1, n1);
            if (check_sim < 0)
            {
                check_sim = BigInteger.Abs(check_sim);

            }
            if (check_sim == hash_for_Epub)
            {
                label17.Text = "Избирателю сообщено что он авторизирован";
                MessageBox.Show("ХЭШ и подпись регистратора - Совпадают", "Примечание");
                MessageBox.Show("Сейчас будет вам представлена бюллетень", "Примечание");
            }
            else
                MessageBox.Show("ХЭШ и подпись регистратора - Не совпадают", "Ошибка!");
            
            step6 fm = new step6();
            fm.ShowDialog();
            groupBox10.Enabled = fm.isEnableGB;
            groupBox11.Enabled = fm.isEnableGB;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BigInteger check_hash = BigInteger.ModPow(sign_B, exp2, n2);
            if (check_hash < 0)
            {
                check_hash = BigInteger.Abs(check_hash);

            }
            if (check_hash == hash_B)
            {
                MessageBox.Show("ХЭШи - Совпадают", "Примечание");
                textBox1.Text = "{" + exp2.ToString() + ";" + n2.ToString() + "}";  //открытый
                textBox2.Text = BitConverter.ToString(enc_B);
                textBox3.Text = sign_B.ToString();
                label13.Text = "От избирателя получен новый набор";
                AES_key_rec_txt.Text = BitConverter.ToString(key_enc_B);
            }
            else
            {
                MessageBox.Show("ХЭШи  - Не совпадают", "Ошибка!");
                textBox1.Text = "Ошибка";  //открытый
                textBox2.Text = "Ошибка";
                textBox3.Text = "Ошибка";
                AES_key_rec_txt.Text = "Ошибка";
                textBox4.Text = "Ошибка";

                key_enc_B = null;
                IV_enc_B = null;
            }
        }

        static string DecryptStringFromBytesAes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Проверяем аргументы
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Строка, для хранения расшифрованного текста
            string plaintext;

            // Создаем объект класса AES,
            // Ключ и IV
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Создаем объект, который определяет основные операции преобразований.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Создаем поток для расшифрования.
                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Читаем расшифрованное сообщение и записываем в строку
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        private void button13_Click(object sender, EventArgs e)
        {
            //var myAes = Aes.Create();

            string roundtrip = DecryptStringFromBytesAes(enc_B, key_enc_B, IV_enc_B);
            textBox4.Text = roundtrip;
            MessageBox.Show("Поздравляем!!! Тайное голосование прошло успешно!", "Congratulate");
 
        }

        
    }
}
