using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Language : helloworld.Form_orig
    {
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(884, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(648, 302);
            this.button1.TabIndex = 0;
            this.button1.Text = "英語";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(157, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(648, 302);
            this.button2.TabIndex = 1;
            this.button2.Text = "Japanese";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(474, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(724, 257);
            this.button3.TabIndex = 2;
            this.button3.Text = "RETURN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.ClientSize = new System.Drawing.Size(1680, 1095);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Language";
            this.Text = "Gengo sentaku/セレクトランゲッジ";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            selectMenu newform = new selectMenu();
            newform.Show();
            this.Dispose();
        }
    }
}