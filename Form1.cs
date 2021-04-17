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
            var street = textBox1.Text;
            var city = textBox2.Text;
            var state = textBox3.Text;
            var zip = textBox4.Text;

            var queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");

            if( street != string.Empty)
            {
                queryaddress.Append(street + "," + "+");
            }
            if (city != string.Empty)
            {
                queryaddress.Append(city + "," + "+");
            }
            if (state != string.Empty)
            {
                queryaddress.Append(state + "," + "+");
            }
            if (zip != string.Empty)
            {
                queryaddress.Append(zip + "," + "+");
            }

            webViewCompatible1.Navigate(queryaddress.ToString());

        }
    }
}
