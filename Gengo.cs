using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Gengo : helloworld.Form_orig
    {
        public Gengo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            selectMenu newform = new selectMenu();
            newform.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);
            MessageBox.Show("This language has been already Japaneeees!" , "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);
            MessageBox.Show("もうすぐ実装予定！\n乞うご期待！" , "ごめんちゃい", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}
