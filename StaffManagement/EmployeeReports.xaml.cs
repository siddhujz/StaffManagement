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
    /// Interaction logic for EmployeeReports.xaml
    /// </summary>
    public partial class EmployeeReports : Page
    {
        public EmployeeReports()
        {
            InitializeComponent();
        }

        private void performance_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            PerformanceReport performanceReport = new PerformanceReport();
            this.NavigationService.Navigate(performanceReport);
        }

        private void qa_Trending_Button_Click(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            QATrending qaTrending = new QATrending();
            this.NavigationService.Navigate(qaTrending);
        }

        private void monthly_Qualitivity_Button_Click(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            MonthlyQualitivity monthlyQualitivity = new MonthlyQualitivity();
            this.NavigationService.Navigate(monthlyQualitivity);
        }
    }
}
