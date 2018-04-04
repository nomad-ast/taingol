namespace taingol
{
    partial class step6
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.enc_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.aes_key = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hash_extB_txt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sign_hash_txt = new System.Windows.Forms.TextBox();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.sign_hash_txt);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.hash_extB_txt);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.enc_txt);
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.textBox2);
            this.groupBox8.Controls.Add(this.aes_key);
            this.groupBox8.Controls.Add(this.button12);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(216, 419);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "7шаг";
            // 
            // enc_txt
            // 
            this.enc_txt.Location = new System.Drawing.Point(11, 182);
            this.enc_txt.Multiline = true;
            this.enc_txt.Name = "enc_txt";
            this.enc_txt.Size = new System.Drawing.Size(190, 37);
            this.enc_txt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зашифровать сообщение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сообщение с выбранным решением";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 45);
            this.textBox2.TabIndex = 2;
            // 
            // aes_key
            // 
            this.aes_key.Location = new System.Drawing.Point(11, 48);
            this.aes_key.Name = "aes_key";
            this.aes_key.Size = new System.Drawing.Size(190, 20);
            this.aes_key.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(11, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(190, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "Создать Esecret";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отправить набор в ЦИК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Создать ХЭШ выбора";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hash_extB_txt
            // 
            this.hash_extB_txt.Location = new System.Drawing.Point(11, 256);
            this.hash_extB_txt.Multiline = true;
            this.hash_extB_txt.Name = "hash_extB_txt";
            this.hash_extB_txt.Size = new System.Drawing.Size(187, 32);
            this.hash_extB_txt.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Подписать ХЭШ закрытым ключом избирателя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sign_hash_txt
            // 
            this.sign_hash_txt.Location = new System.Drawing.Point(11, 335);
            this.sign_hash_txt.Multiline = true;
            this.sign_hash_txt.Name = "sign_hash_txt";
            this.sign_hash_txt.Size = new System.Drawing.Size(187, 49);
            this.sign_hash_txt.TabIndex = 10;
            // 
            // step6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 443);
            this.Controls.Add(this.groupBox8);
            this.Name = "step6";
            this.Text = "Бюллетень";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox aes_key;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox enc_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox hash_extB_txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox sign_hash_txt;
        private System.Windows.Forms.Button button4;
    }
}