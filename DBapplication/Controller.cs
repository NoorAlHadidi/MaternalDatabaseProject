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
        public bool SearchAdmin(string username, string password)
        {
            string query = "SELECT Username, User_Password FROM DATABASE_ADMIN WHERE Username = '" + username + "' AND User_Password = '" + password + "';";
            DataTable DT = DBMan.ExecuteReader(query);
            return DT.Rows.Count != 0;
        }
        public bool SearchMother(string username, string password)
        {
            string query = "SELECT Username, User_Password FROM MOTHER WHERE Username = '" + username + "' AND User_Password = '" + password + "';";
            DataTable DT = DBMan.ExecuteReader(query);
            return DT.Rows.Count != 0;
        }
        public bool SearchGyno(string username, string password)
        {
            string query = "SELECT Username, User_Password FROM DOCTOR WHERE Username = '" + username + "' AND User_Password = '" + password + "' AND Doctor_Type = 'Gynecologist';";
            DataTable DT = DBMan.ExecuteReader(query);
            return DT.Rows.Count != 0;
        }
        public bool SearchPed(string username, string password)
        {
            string query = "SELECT Username, User_Password FROM DOCTOR WHERE Username = '" + username + "' AND User_Password = '" + password + "' AND Doctor_Type = 'Pediatrician';";
            DataTable DT = DBMan.ExecuteReader(query);
            return DT.Rows.Count != 0;
        }
        public int InsertMother(string username, string fname, string lname, string email, string password)
        {
            string query = "INSERT INTO MOTHER(Username, First_Name, Last_Name, Email_Address, User_Password)" + "VALUES ('" + username + "', '" + fname + "', '" + lname + "', '" + email + "', '" + password + "');";            return DBMan.ExecuteNonQuery(query);
        }
        public int InsertGyno(string username, string fname, string lname, string email, string password)
        {
            string type = "Gynecologist";
            string query = "INSERT INTO DOCTOR(Username, First_Name, Last_Name, Doctor_Type, Email_Address, User_Password)" + "VALUES ('" + username + "', '" + fname + "', '" + lname + "', '" + type + "', '" + email + "', '" + password + "');";
            return DBMan.ExecuteNonQuery(query);
        }
        public int InsertPed(string username, string fname, string lname, string email, string password)
        {
            string type = "Pediatrician";
            string query = "INSERT INTO DOCTOR(Username, First_Name, Last_Name, Doctor_Type, Email_Address, User_Password)" + "VALUES ('" + username + "', '" + fname + "', '" + lname + "', '" + type + "', '" + email + "', '" + password + "');";
            return DBMan.ExecuteNonQuery(query);
        }
    }
}
