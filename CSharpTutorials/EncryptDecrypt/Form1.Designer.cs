﻿
namespace EncryptDecrypt
{
    partial class Form1
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
            this.txtValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncry = new System.Windows.Forms.Label();
            this.txtDecry = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.Location = new System.Drawing.Point(12, 9);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(37, 13);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "Value:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(56, 108);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncry
            // 
            this.txtEncry.AutoSize = true;
            this.txtEncry.Location = new System.Drawing.Point(5, 47);
            this.txtEncry.Name = "txtEncry";
            this.txtEncry.Size = new System.Drawing.Size(46, 13);
            this.txtEncry.TabIndex = 3;
            this.txtEncry.Text = "Encrypt:";
            // 
            // txtDecry
            // 
            this.txtDecry.AutoSize = true;
            this.txtDecry.Location = new System.Drawing.Point(5, 85);
            this.txtDecry.Name = "txtDecry";
            this.txtDecry.Size = new System.Drawing.Size(44, 13);
            this.txtDecry.TabIndex = 4;
            this.txtDecry.Text = "Decrypt";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(192, 108);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 140);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDecry);
            this.Controls.Add(this.txtEncry);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtValue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt&Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label txtEncry;
        private System.Windows.Forms.Label txtDecry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

