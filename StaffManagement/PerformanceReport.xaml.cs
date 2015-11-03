using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PerformanceReport.xaml
    /// </summary>
    public partial class PerformanceReport : Page
    {
        public PerformanceReport()
        {
            InitializeComponent();
            setBindings();
        }

        private void generate_Performance_Report(object sender, EventArgs e)
        {
        }

        void setBindings()
        {
            //Weeks weeks = new Weeks();

            ObservableCollection<String> collection = new ObservableCollection<String>();
            String seatSQL = "SELECT cast(week as date) FROM revint.[staff_management].prod_emp_hours GROUP BY week ORDER BY week DESC";
            new comboMaker(seatSQL, collection);

            //collection.Add("Something");
            
            Binding weeksbinding = new Binding();

            weeksbinding.Source = collection;
            //weeksbinding.Source = weeks;
            monthComboBox.SetBinding(ListBox.ItemsSourceProperty, weeksbinding);
        }

        private void cancel_And_Go_Back(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            EmployeeReports employeeReports = new EmployeeReports();
            this.NavigationService.Navigate(employeeReports);
        }
    }
}
