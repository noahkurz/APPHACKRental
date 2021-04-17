using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPHACKRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var queryaddress = generateWebQuery();
            googleMap.Navigate(queryaddress.ToString());
        }

        private StringBuilder generateWebQuery()
        {
            var queryaddress = new StringBuilder("http://google.com/maps?q=");

            if (!string.IsNullOrEmpty(city_textbox.Text))
            {
                queryaddress.Append(street_textbox.Text + "," + "+");
            } else
            {
                queryaddress.Append(street_textbox.Text);
            }

            if (!string.IsNullOrEmpty(state_textbox.Text))
            {
                queryaddress.Append(city_textbox.Text + "," + "+");
            }
            else
            {
                queryaddress.Append(city_textbox.Text);
            }

            if (!string.IsNullOrEmpty(zip_textbox.Text))
            {
                queryaddress.Append(state_textbox.Text + "," + "+");
            }
            else
            {
                queryaddress.Append(state_textbox.Text);
            }

            queryaddress.Append(zip_textbox.Text);

            return queryaddress;

        }
    }
}
