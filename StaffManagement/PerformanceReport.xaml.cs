﻿using System;
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
    /// Interaction logic for PerformanceReport.xaml
    /// </summary>
    public partial class PerformanceReport : Page
    {
        public PerformanceReport()
        {
            InitializeComponent();
        }

        private void generate_Performance_Report(object sender, EventArgs e)
        {
        }

        private void cancel_And_Go_Back(object sender, RoutedEventArgs e)
        {
            // View Employee Reports
            EmployeeReports employeeReports = new EmployeeReports();
            this.NavigationService.Navigate(employeeReports);
        }
    }
}
