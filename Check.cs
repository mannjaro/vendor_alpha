using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Check : helloworld.Form_orig
    {
        public Check()
        {
            InitializeComponent();
            textBox2.Text = money.ToString();

        }
        private string[,] csvData;
        private int csvIndex;

        public string[,] CSVData
        {
            get { return this.csvData; }
            set { this.csvData = value; }
        }

        public int CSVIndex
        {
            get { return this.csvIndex; }
            set { this.csvIndex = value; }
        }

        private void Check_Load(object sender, EventArgs e)
        {
            label1.Text = csvData[1, csvIndex - 1];
            label3.Text = csvData[2, csvIndex - 1];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
