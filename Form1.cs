using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = "DenisRafi";
            String Pass = "123456789";

            if ((textBox1.Text == Username) && (textBox2.Text == Pass))
                MessageBox.Show("Login Successful");
            else
                MessageBox.Show("Enter valid Username & Password");
        }
    }
}
