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
    public partial class selectMenu : helloworld.Form_orig
    {
        string[,] csvData = new string[3, 255];
        public selectMenu()
        {
            InitializeComponent();
            textBox1.Text = money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Dispose();
        }

        private void buyTicket(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            int tempMoney = money;
            Button btn = (Button)sender;
            item_name = btn.Text.Replace("\r\n", "");
            buy_ticket(item_name);
            if (money < 0)
            {
                money = tempMoney;
                return;
            }
            Meal newform = new Meal();
            newform.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Logging
            this.log(this, sender, e);

            //To DonburiMenu
            DonburiMenu newForm = new DonburiMenu();
            newForm.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectMenu_Load(object sender, EventArgs e)
        {
            //csvReading
            TextFieldParser parser = new TextFieldParser("menu.csv", System.Text.Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;
            //Diveded By Comma
            parser.SetDelimiters(",");
            Int16 i = 0;
            while (!parser.EndOfData)
            {

                string[] row = parser.ReadFields();
                csvData[0, i] = row[0];
                csvData[1, i] = row[1];
                csvData[2, i] = row[2];

                i++;
            }
        }
    }
}
