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
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Page
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void generate_Employee_View(object sender, EventArgs e)
        {
        }

        private void cancel_And_Go_Back(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            StaffManagementHome staffManagementHome = new StaffManagementHome();
            this.NavigationService.Navigate(staffManagementHome);
        }
    }
}
