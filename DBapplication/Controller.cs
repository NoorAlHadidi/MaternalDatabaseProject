using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MaternalDatabase
{
    public class Controller
    {
        DBManager DBMan;
        public Controller()
        {
            DBMan = new DBManager();
        }
        public void TerminateConnection()
        {
            DBMan.CloseConnection();
        }
    }
}
