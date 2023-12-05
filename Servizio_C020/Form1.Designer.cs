using System;

namespace Servizio_C020
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
            this.Risultato = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Voucher = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Risultato
            // 
            this.Risultato.Location = new System.Drawing.Point(13, 84);
            this.Risultato.Multiline = true;
            this.Risultato.Name = "Risultato";
            this.Risultato.Size = new System.Drawing.Size(319, 354);
            this.Risultato.TabIndex = 0;
            this.Risultato.TextChanged += new System.EventHandler(this.Risultato_TextChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(13, 25);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(148, 53);
            this.Create.TabIndex = 1;
            this.Create.Text = "button1";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Voucher
            // 
            this.Voucher.Location = new System.Drawing.Point(208, 25);
            this.Voucher.Name = "Voucher";
            this.Voucher.Size = new System.Drawing.Size(148, 53);
            this.Voucher.TabIndex = 2;
            this.Voucher.Text = "button1";
            this.Voucher.UseVisualStyleBackColor = true;
            this.Voucher.Click += new System.EventHandler(this.Voucher_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 354);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Voucher);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Risultato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }









        #endregion

        private System.Windows.Forms.TextBox Risultato;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Voucher;
        private System.Windows.Forms.TextBox textBox1;
    }
}

