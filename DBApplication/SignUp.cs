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
    public partial class SignUp : KryptonForm
    {
        Controller ControllerObj;
        public SignUp()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "" || kryptonTextBox2.Text == "" || kryptonTextBox3.Text == "" || kryptonTextBox4.Text == "" || kryptonTextBox5.Text == "" || kryptonTextBox6.Text == "")
            {
                MessageBox.Show("Please, fill all fields.");
                return;
            }
            if (kryptonTextBox3.Text != kryptonTextBox4.Text)
            {
                MessageBox.Show("Please, re-enter your password correctly.");
                return;
            }
            int result = ControllerObj.InsertMother(kryptonTextBox2.Text, kryptonTextBox5.Text, kryptonTextBox6.Text, kryptonTextBox1.Text, kryptonTextBox3.Text);
            if (result == 0)
            {
                MessageBox.Show("Insertion into the system was unsuccessful.");
            }
            else
            {
                MessageBox.Show("Insertion into the system was successful.");
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "" || kryptonTextBox2.Text == "" || kryptonTextBox3.Text == "" || kryptonTextBox4.Text == "" || kryptonTextBox5.Text == "" || kryptonTextBox6.Text == "")
            {
                MessageBox.Show("Please, fill all fields.");
                return;
            }
            if (kryptonTextBox3.Text != kryptonTextBox4.Text)
            {
                MessageBox.Show("Please, confirm your password");
                return;
            }
            int result = ControllerObj.InsertGyno(kryptonTextBox2.Text, kryptonTextBox5.Text, kryptonTextBox6.Text, kryptonTextBox1.Text, kryptonTextBox3.Text);
            if (result == 0)
            {
                MessageBox.Show("Insertion into the system was unsuccessful.");
            }
            else
            {
                MessageBox.Show("Insertion into the system was successful.");
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "" || kryptonTextBox2.Text == "" || kryptonTextBox3.Text == "" || kryptonTextBox4.Text == "" || kryptonTextBox5.Text == "" || kryptonTextBox6.Text == "")
            {
                MessageBox.Show("Please, fill all fields.");
                return;
            }
            if (kryptonTextBox3.Text != kryptonTextBox4.Text)
            {
                MessageBox.Show("Please, confirm your password");
                return;
            }
            int result = ControllerObj.InsertPed(kryptonTextBox2.Text, kryptonTextBox5.Text, kryptonTextBox6.Text, kryptonTextBox1.Text, kryptonTextBox3.Text);
            if (result == 0)
            {
                MessageBox.Show("Insertion into the system was unsuccessful.");
            }
            else
            {
                MessageBox.Show("Insertion into the system was successful.");
            }
        }
    }
}
