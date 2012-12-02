using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BerlinClockWindowsViewer.ViewModels;
using BerlinClockWindowsViewer.Views;

namespace BerlinClockWindowsViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            var clockView = new ClockView();
            var clockViewModel = new ClockViewModel();

            clockView.DataContext = clockViewModel;
            clockView.Show();
        }       
    }
}
