using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MaternalDatabase
{
    public partial class InitialForm : KryptonForm
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SignUp SU = new SignUp();
            SU.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            LogIn LI = new LogIn();
            LI.Show();
        }
    }
}
