using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class DonburiMenu2 : helloworld.Form_orig
    {
        public DonburiMenu2()
        {
            InitializeComponent();
            textBox2.Text = money.ToString();
        }
        private string[,] csvData;
        private Button[] buttons;
        float fontSize = 14f;

        public string[,] CSVData
        {
            get { return this.csvData; }
            set { this.csvData = value; }
        }

        private void DonburiMenu2_Load(object sender, EventArgs e)
        {
            this.buttons = new Button[11];
            for (int i = 0; i < 11; i++)
            {
                this.buttons[i] = new Button();

                this.buttons[i].Text = csvData[1, i + 41] + "\n" + csvData[2, i + 41];
                this.buttons[i].Top = 100 * i;
                this.buttons[i].Size = new Size(200, 110);
                this.buttons[i].Font = new Font(buttons[i].Font.OriginalFontName, fontSize);
                this.buttons[i].Click += new System.EventHandler(btnclick);

                if (money >= int.Parse(csvData[2, i + 25]))
                {
                    this.buttons[i].BackColor = Color.Orange;
                }
                else
                {
                    this.buttons[i].Enabled = false;
                }

                flowLayoutPanel1.Controls.Add(this.buttons[i]);
            }
        }

        private void btnclick(object sender, System.EventArgs e)
        {
            this.log(this, sender, e);

            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            DonburiMenu newForm = new DonburiMenu();
            newForm.CSVData = this.csvData;
            newForm.Show();
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            insertMoney newForm = new insertMoney();
            newForm.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.log(this, sender, e);

            selectMenu newForm = new selectMenu();
            newForm.Show();
            this.Dispose();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
