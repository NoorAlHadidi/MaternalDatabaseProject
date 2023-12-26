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
        public int SearchAdmin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM DATABASE_ADMIN WHERE Username = '" + username + "' AND User_Password = '" + password + "';";
            return Convert.ToInt32(DBMan.ExecuteScalar(query));
        }
        public int SearchMother(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM MOTHER WHERE Username = '" + username + "' AND User_Password = '" + password + "';";
            return Convert.ToInt32(DBMan.ExecuteScalar(query));
        }
        public int SearchGyno(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM DOCTOR WHERE Username = '" + username + "' AND User_Password = '" + password + "' AND Doctor_Type = 'Gynecologist';";
            return Convert.ToInt32(DBMan.ExecuteScalar(query));
        }
        public int SearchPed(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM DOCTOR WHERE Username = '" + username + "' AND User_Password = '" + password + "' AND Doctor_Type = 'Pediatrician';";
            return Convert.ToInt32(DBMan.ExecuteScalar(query));
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
