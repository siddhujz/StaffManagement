using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement
{

    //Seats object that inherits from ObservableCollection in order to be a binding source for a combo box contents  (dictionary seatIDs is reference between names and their ids in the database):
    public class Weeks : ObservableCollection<string>
    {
        public Weeks()
        {
            //String seatSQL = "SELECT Id, Name FROM [REVINT].[dbo].[ED_Seats] ORDER BY Name";
            String seatSQL = "SELECT week FROM [staff_management].prod_emp_hours ORDER BY week DESC GROUP BY week";
            new comboMaker(seatSQL, this);
        }
    }

    //Combo maker, adds desired sql content to ObservableCollection binding source (the class above) and its reference dictionary:
    public class comboMaker
    {
        public comboMaker(String sqlCmd, Dictionary<String, String> dictionary, ObservableCollection<string> comboClass)
        {
            object[] obj = new object[10];

            String cxnString = "Driver={SQL Server};Server=HC-sql7;Database=REVINT;Trusted_Connection=yes;";
            using (OdbcConnection connection = new OdbcConnection(cxnString))
            {
                OdbcCommand command = new OdbcCommand(sqlCmd, connection);
                connection.Open();
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int numCols = reader.GetValues(obj);
                    if (numCols >= 2)
                    {
                        dictionary.Add(obj[1].ToString(), obj[0].ToString());
                        comboClass.Add(obj[1].ToString());
                    }
                }
            }
        }
        public comboMaker(String sqlCmd, ObservableCollection<string> comboClass)
        {
            object[] obj = new object[10];

            String cxnString = "Driver={SQL Server};Server=HC-sql7;Database=REVINT;Trusted_Connection=yes;";
            using (OdbcConnection connection = new OdbcConnection(cxnString))
            {
                OdbcCommand command = new OdbcCommand(sqlCmd, connection);
                connection.Open();
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int numCols = reader.GetValues(obj);
                    if (numCols > 0)
                    {
                        comboClass.Add(obj[0].ToString());
                    }
                }
            }
        }
    }
}
