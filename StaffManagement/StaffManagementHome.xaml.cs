using System;
using System.Collections.Generic;
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
    /// Interaction logic for StaffManagementHome.xaml
    /// </summary>
    public partial class StaffManagementHome : Page
    {
        public StaffManagementHome()
        {
            InitializeComponent();
        }

        private void employee_View_Button_Click(object sender, RoutedEventArgs e)
        {
            // Navigate the page to Employee View Form
            EmployeeView employeeView = new EmployeeView();
            this.NavigationService.Navigate(employeeView);
        }

        private void employee_Reports_Button_Click(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            EmployeeReports employeeReports = new EmployeeReports();
            this.NavigationService.Navigate(employeeReports);
        }
    }
}
