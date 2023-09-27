using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cWorker u = new cWorker();
            u.FirstName = "arash";
            u.LastName = "azad";
            u.SocialSecurity = "12345";
            label1.Text = u.Concatinate();

        }

        private string Temp(cEmployee u)
        {
            return u.Concatinate();
        }
    }
}
