using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_form
{
    public partial class userRegiForm : Form
    {
        public userRegiForm()
        {
            InitializeComponent();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            if(textBox_middleName.Text.Trim()=="")
            {
                MessageBox.Show("Enter First Name ");
                return;
            }
            string firstName = textBox_firstName.Text;            
            string middleName = textBox_middleName.Text;
            string lastName = textBox_lastName.Text;

            string fullName = firstName + " "+ middleName + " " + lastName;
           
            textBox_fullName.Text = fullName;

            textBox_firstName.Clear();
            textBox_middleName.Clear();
            textBox_lastName.Clear();

        }


    }
}
