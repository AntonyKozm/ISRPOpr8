
namespace ISRPOpr7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_decrypt = new System.Windows.Forms.Button();
            this.bt_encrypt = new System.Windows.Forms.Button();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_to = new System.Windows.Forms.Button();
            this.bt_from = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_num2
            // 
            this.tb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_num2.Location = new System.Drawing.Point(489, 161);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 36);
            this.tb_num2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(351, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Число 2: ";
            // 
            // tb_num1
            // 
            this.tb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_num1.Location = new System.Drawing.Point(189, 161);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 36);
            this.tb_num1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Число 1: ";
            // 
            // bt_decrypt
            // 
            this.bt_decrypt.Location = new System.Drawing.Point(356, 224);
            this.bt_decrypt.Name = "bt_decrypt";
            this.bt_decrypt.Size = new System.Drawing.Size(204, 53);
            this.bt_decrypt.TabIndex = 19;
            this.bt_decrypt.Text = "Расшифровать";
            this.bt_decrypt.UseVisualStyleBackColor = true;
            this.bt_decrypt.Click += new System.EventHandler(this.bt_decrypt_Click);
            // 
            // bt_encrypt
            // 
            this.bt_encrypt.Location = new System.Drawing.Point(121, 224);
            this.bt_encrypt.Name = "bt_encrypt";
            this.bt_encrypt.Size = new System.Drawing.Size(204, 53);
            this.bt_encrypt.TabIndex = 18;
            this.bt_encrypt.Text = "Зашифровать";
            this.bt_encrypt.UseVisualStyleBackColor = true;
            this.bt_encrypt.Click += new System.EventHandler(this.bt_encrypt_Click);
            // 
            // tb_to
            // 
            this.tb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_to.Location = new System.Drawing.Point(300, 80);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(393, 41);
            this.tb_to.TabIndex = 17;
            // 
            // tb_from
            // 
            this.tb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_from.Location = new System.Drawing.Point(300, 20);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(393, 41);
            this.tb_from.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Куда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Откуда";
            // 
            // bt_to
            // 
            this.bt_to.Location = new System.Drawing.Point(176, 83);
            this.bt_to.Name = "bt_to";
            this.bt_to.Size = new System.Drawing.Size(113, 38);
            this.bt_to.TabIndex = 13;
            this.bt_to.Text = "Выбрать";
            this.bt_to.UseVisualStyleBackColor = true;
            this.bt_to.Click += new System.EventHandler(this.bt_to_Click);
            // 
            // bt_from
            // 
            this.bt_from.Location = new System.Drawing.Point(176, 23);
            this.bt_from.Name = "bt_from";
            this.bt_from.Size = new System.Drawing.Size(113, 38);
            this.bt_from.TabIndex = 12;
            this.bt_from.Text = "Выбрать";
            this.bt_from.UseVisualStyleBackColor = true;
            this.bt_from.Click += new System.EventHandler(this.bt_from_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 302);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_decrypt);
            this.Controls.Add(this.bt_encrypt);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_to);
            this.Controls.Add(this.bt_from);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_decrypt;
        private System.Windows.Forms.Button bt_encrypt;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_to;
        private System.Windows.Forms.Button bt_from;
    }
}

