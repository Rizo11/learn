using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var newSchool = new School();
            newSchool.Name = textBoxName.Text;
            newSchool.Phone = textBoxPhone.Text;
            newSchool.Email = textBoxEmail.Text;
            newSchool.Address = textBoxAddress.Text;
            newSchool.Zip = textBoxZip.Text;
            newSchool.Website = textBoxWebsite.Text;
            newSchool.YearEstablished = textBoxYearEstablished.Text;
            try
            {
                newSchool.TelegramNick = textBoxTelegramChannel.Text;
                MessageBox.Show(newSchool.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var std = new Student();
            std.FullName = "NA";
            MessageBox.Show(std.SendMessage());
        }
    }
}
