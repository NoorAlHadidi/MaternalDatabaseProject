using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MaternalDatabase
{
    public partial class LogIn : KryptonForm
    {
        Controller ControllerObj;
        public LogIn()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "" || kryptonTextBox2.Text == "")
            {
                MessageBox.Show("Please, fill all fields.");
                return;
            }
            int resultadmin = ControllerObj.SearchAdmin(kryptonTextBox1.Text, kryptonTextBox2.Text);
            if (resultadmin == 1)
            {
                Admin A = new Admin();
                A.Show();
                return;
            }
            int resultmother = ControllerObj.SearchMother(kryptonTextBox1.Text, kryptonTextBox2.Text);
            if (resultmother == 1)
            {
                Mother M = new Mother();
                M.Show();
                return;
            }
            int resultgyno = ControllerObj.SearchGyno(kryptonTextBox1.Text, kryptonTextBox2.Text);
            if (resultgyno == 1)
            {
                Gynecologist G = new Gynecologist();
                G.Show();
                return;
            }
            int resultped = ControllerObj.SearchPed(kryptonTextBox1.Text, kryptonTextBox2.Text);
            if (resultped == 1)
            {
                Pediatrician P = new Pediatrician();
                P.Show();
                return;
            }
            MessageBox.Show("Username/Password is incorrect.");
            kryptonTextBox1.Text = "";
            kryptonTextBox2.Text = "";
            return;
        }
    }
}
