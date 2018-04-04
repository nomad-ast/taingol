namespace taingol
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.get_pair = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AES_key_rec_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.f_text = new System.Windows.Forms.TextBox();
            this.hash_text = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.g_get_txt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseKeySend_E = new System.Windows.Forms.TextBox();
            this.OpenKeySend_E = new System.Windows.Forms.TextBox();
            this.q2_val = new System.Windows.Forms.TextBox();
            this.p2_val = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.g_text = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseKeySend_V = new System.Windows.Forms.TextBox();
            this.OpenKeySend_V = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.q_val = new System.Windows.Forms.TextBox();
            this.p_val = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 537);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "А(ЦИК)";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.get_pair);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.button11);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(7, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(221, 106);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "6шаг";
            // 
            // get_pair
            // 
            this.get_pair.Location = new System.Drawing.Point(6, 19);
            this.get_pair.Name = "get_pair";
            this.get_pair.Size = new System.Drawing.Size(204, 20);
            this.get_pair.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 45);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(204, 40);
            this.button11.TabIndex = 1;
            this.button11.Text = "Проверка подлинности открытого ключа избирателя";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Ключ AES";
            // 
            // AES_key_rec_txt
            // 
            this.AES_key_rec_txt.Location = new System.Drawing.Point(6, 45);
            this.AES_key_rec_txt.Multiline = true;
            this.AES_key_rec_txt.Name = "AES_key_rec_txt";
            this.AES_key_rec_txt.Size = new System.Drawing.Size(201, 38);
            this.AES_key_rec_txt.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 134);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 44);
            this.textBox4.TabIndex = 10;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(7, 103);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(201, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "Расшифровать бюллетень";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Подписанный ХЭШ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Зашифрованная бюллетень избирателя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Открытый ключ избирателя";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 35);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 22);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(205, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Проверка подлинности сообщения ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 543);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E(избиратель)";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.f_text);
            this.groupBox8.Controls.Add(this.hash_text);
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(6, 273);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(216, 144);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "3шаг";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Вычислить ХЭШ Epub";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // f_text
            // 
            this.f_text.Location = new System.Drawing.Point(5, 120);
            this.f_text.Name = "f_text";
            this.f_text.Size = new System.Drawing.Size(195, 20);
            this.f_text.TabIndex = 14;
            // 
            // hash_text
            // 
            this.hash_text.Location = new System.Drawing.Point(6, 48);
            this.hash_text.Name = "hash_text";
            this.hash_text.Size = new System.Drawing.Size(195, 20);
            this.hash_text.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(195, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Вычислить f";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.g_get_txt);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(6, 423);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 114);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "5шаг";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(10, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(195, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Проверка подлинности подписи";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(195, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Отправить в ЦИК";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // g_get_txt
            // 
            this.g_get_txt.Location = new System.Drawing.Point(10, 48);
            this.g_get_txt.Name = "g_get_txt";
            this.g_get_txt.Size = new System.Drawing.Size(196, 20);
            this.g_get_txt.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.CloseKeySend_E);
            this.groupBox5.Controls.Add(this.OpenKeySend_E);
            this.groupBox5.Controls.Add(this.q2_val);
            this.groupBox5.Controls.Add(this.p2_val);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(6, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 249);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "2шаг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "q";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "p";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Закрытый ключ Epriv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Открытый ключ Epub";
            // 
            // CloseKeySend_E
            // 
            this.CloseKeySend_E.Location = new System.Drawing.Point(6, 214);
            this.CloseKeySend_E.Name = "CloseKeySend_E";
            this.CloseKeySend_E.Size = new System.Drawing.Size(196, 20);
            this.CloseKeySend_E.TabIndex = 5;
            // 
            // OpenKeySend_E
            // 
            this.OpenKeySend_E.Location = new System.Drawing.Point(6, 171);
            this.OpenKeySend_E.Name = "OpenKeySend_E";
            this.OpenKeySend_E.Size = new System.Drawing.Size(196, 20);
            this.OpenKeySend_E.TabIndex = 4;
            // 
            // q2_val
            // 
            this.q2_val.Location = new System.Drawing.Point(10, 101);
            this.q2_val.Name = "q2_val";
            this.q2_val.Size = new System.Drawing.Size(196, 20);
            this.q2_val.TabIndex = 3;
            // 
            // p2_val
            // 
            this.p2_val.Location = new System.Drawing.Point(10, 58);
            this.p2_val.Name = "p2_val";
            this.p2_val.Size = new System.Drawing.Size(196, 20);
            this.p2_val.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Вычислить ключи";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Генерация p и q";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(15, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 418);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "V(ЦУР)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.g_text);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(8, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(186, 124);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "4шаг";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Расшифрованный f\r\n";
            // 
            // g_text
            // 
            this.g_text.Location = new System.Drawing.Point(4, 57);
            this.g_text.Name = "g_text";
            this.g_text.Size = new System.Drawing.Size(177, 20);
            this.g_text.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Расшифровать f";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.CloseKeySend_V);
            this.groupBox4.Controls.Add(this.OpenKeySend_V);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.q_val);
            this.groupBox4.Controls.Add(this.p_val);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(4, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 254);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Закрытый ключ Vpriv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Открытый ключ Vpub";
            // 
            // CloseKeySend_V
            // 
            this.CloseKeySend_V.Location = new System.Drawing.Point(5, 217);
            this.CloseKeySend_V.Name = "CloseKeySend_V";
            this.CloseKeySend_V.Size = new System.Drawing.Size(180, 20);
            this.CloseKeySend_V.TabIndex = 7;
            // 
            // OpenKeySend_V
            // 
            this.OpenKeySend_V.Location = new System.Drawing.Point(6, 174);
            this.OpenKeySend_V.Name = "OpenKeySend_V";
            this.OpenKeySend_V.Size = new System.Drawing.Size(179, 20);
            this.OpenKeySend_V.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Вычислить ключи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "p";
            // 
            // q_val
            // 
            this.q_val.Location = new System.Drawing.Point(2, 105);
            this.q_val.Name = "q_val";
            this.q_val.Size = new System.Drawing.Size(182, 20);
            this.q_val.TabIndex = 2;
            // 
            // p_val
            // 
            this.p_val.Location = new System.Drawing.Point(2, 59);
            this.p_val.Name = "p_val";
            this.p_val.Size = new System.Drawing.Size(182, 20);
            this.p_val.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Генерация p и q";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button12);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.textBox2);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.textBox3);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(7, 131);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(221, 210);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "8шаг";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.button13);
            this.groupBox11.Controls.Add(this.textBox4);
            this.groupBox11.Controls.Add(this.AES_key_rec_txt);
            this.groupBox11.Enabled = false;
            this.groupBox11.Location = new System.Drawing.Point(7, 347);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(214, 190);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "9шаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Тайное голосование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q_val;
        private System.Windows.Forms.TextBox p_val;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CloseKeySend_V;
        private System.Windows.Forms.TextBox OpenKeySend_V;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CloseKeySend_E;
        private System.Windows.Forms.TextBox OpenKeySend_E;
        private System.Windows.Forms.TextBox q2_val;
        private System.Windows.Forms.TextBox p2_val;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox hash_text;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox f_text;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox g_text;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox g_get_txt;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox get_pair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AES_key_rec_txt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}

