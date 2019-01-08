using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;


namespace helloworld
{
    public partial class DonburiMenu : helloworld.Form_orig
    {
        public DonburiMenu()
        {
            InitializeComponent();
            textBox2.Text = money.ToString();
        }
        private string[,] csvData;
        private Button[] buttons;
        float fontSize = 14f;
        int i = 0;
        public string[,] CSVData
        {
            get { return this.csvData; }
            set { this.csvData = value; }
        }
        private void DonburiMenu_Load(object sender, EventArgs e)
        {
            this.buttons = new Button[16];
            for (int i = 0; i < 16; i++)
            {
                this.buttons[i] = new Button();

                this.buttons[i].Text = csvData[1, i + 31];
                this.buttons[i].Top = 100 * i;

                flowLayoutPanel1.Controls.Add(this.buttons[i]);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnclick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            selectMenu newForm = new selectMenu();
            newForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            insertMoney newForm = new insertMoney();
            newForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            //DonburiMenu2 newForm = new DonburiMenu2();
           // newForm.Show();
           // this.Dispose();
        }

    }
}
