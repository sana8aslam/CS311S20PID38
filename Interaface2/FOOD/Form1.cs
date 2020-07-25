using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FOOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

            bool In = isvalid_id(Id.Text);
            bool na = isvalid_name(name.Text);
            bool lm = isvalid_email(email.Text);
            bool a = isvalid_address(address.Text);
            bool co = isvalid_contact(contact.Text);

            if (In == true && na == true && lm == true &&  a== true && co == true)
            {
                MessageBox.Show("Successfully Registered!");


                string id = Id.Text;
                string Name = name.Text;
                string Password = password.Text;
                string Contact = contact.Text;
                string Address =address.Text;
                string Email = email.Text;
               

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-A0T300M\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into  Customer values(@a,@b,@c,@d,@e,@g,@h)", con);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", Name);
                cmd.Parameters.AddWithValue("@c", Password);
                cmd.Parameters.AddWithValue("@d", Contact);
                cmd.Parameters.AddWithValue("@e", Address);
                cmd.Parameters.AddWithValue("@g", Email);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Data successfully Entered");
            }

        }
        public bool isvalid_name(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid name");
                return false;
            }
        }

        public bool isvalid_id(string n)
        {
            Regex check = new Regex(@"	^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid id");
                return false;
            }
        }

        public bool isvalid_email(string n)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
        }
        public bool isvalid_address(string n)
        {
            Regex check = new Regex(@"^\d+\s[A-z]+\s[A-z]+");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid home address");
                return false;
            }
        }
        public bool isvalid_contact(string n)
        {
            Regex check = new Regex(@"^(([\+]{1}[0-9]{1,3}[\ ]{1}[0-9]{1,2}[\ ]{1}[0-9]{4}[\ ]{1}[0-9]{4})|([0]{1}[0-9]{1}[\ ]{1}[0-9]{4}[\ ]{1}[0-9]{4})|([0]{1}[0-9]{1}[\-]{1}[0-9]{4}[\-]{1}[0-9]{4})|([\(]{1}[0]{1}[0-9]{1}[\)]{1}[\ ]{1}[0-9]{4}([\ ]|[\-]){1}[0-9]{4})|([0-9]{4}([\ ]|[\-])?[0-9]{4})|([0]{1}[0-9]{3}[\ ]{1}[0-9]{3}[\ ]{1}[0-9]{3})|([0]{1}[0-9]{9})|([\(]{1}[0-9]{3}[\)]{1}[\ ]{1}[0-9]{3}[\-]{1}[0-9]{4})|([0-9]{3}([\/]|[\-]){1}[0-9]{3}[\-]{1}[0-9]{4})|([1]{1}[\-]?[0-9]{3}([\/]|[\-]){1}[0-9]{3}[\-]{1}[0-9]{4})|([1]{1}[0-9]{9}[0-9]?)|([0-9]{3}[\.]{1}[0-9]{3}[\.]{1}[0-9]{4})|([\(]{1}[0-9]{3}[\)]{1}[0-9]{3}([\.]|[\-]){1}[0-9]{4}(([\ ]?(x|ext|extension)?)([\ ]?[0-9]{3,4}))?)|([1]{1}[\(]{1}[0-9]{3}[\)]{1}[0-9]{3}([\-]){1}[0-9]{4})|([\+]{1}[1]{1}[\ ]{1}[0-9]{3}[\.]{1}[0-9]{3}[\-]{1}[0-9]{4})|([\+]{1}[1]{1}[\ ]?[\(]{1}[0-9]{3}[\)]{1}[0-9]{3}[\-]{1}[0-9]{4}))$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                return false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
