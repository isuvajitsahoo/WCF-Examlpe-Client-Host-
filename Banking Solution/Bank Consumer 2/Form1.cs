using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Consumer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.BankClient bank = new ServiceReference1.BankClient("NetTcpBinding_IBank");

        private void button1_Click(object sender, EventArgs e)
        {
           
               MessageBox.Show(bank.Increment());
            
        }
    }
}
