using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StaffManagement
{
    /// <summary>
    /// Interaction logic for MonthlyQualitivity.xaml
    /// </summary>
    public partial class MonthlyQualitivity : Page
    {
        public MonthlyQualitivity()
        {
            InitializeComponent();
        }

        private void genarateMonthlyQalitivity(object sender, EventArgs e)
        {
        /*    String connectionString = null;
            SqlConnection sqlConnection;

            //connection String for sql server is "Server = myServerAddress; Database = myDataBase; Trusted_Connection = True"
            connectionString = "Server=HC-sql7;Database=REVINT;Trusted_Connection=True;";
            
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                MessageBox.Show ("Connection Open!");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        */}
    }
}
