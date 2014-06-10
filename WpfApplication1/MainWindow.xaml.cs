using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace WpfApplication1
{


    public class MainWindowViewModel
    {
        public ObservableCollection<string> ListSelection { get; set; }
        public MainWindowViewModel()
        {
            ListSelection = new ObservableCollection<string>
            {
                "One",
                "Two",
                "Three"
            };
            
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowViewModel model;
        
        public MainWindow()
        {
            InitializeComponent();

            model = new MainWindowViewModel();
            

            this.DataContext = model;
        }

        private void bar_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void bar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bar_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void bar_StylusDown(object sender, StylusDownEventArgs e)
        {

        }

        private void bar_StylusMove(object sender, StylusEventArgs e)
        {

        }

        private void bar_StylusUp(object sender, StylusEventArgs e)
        {

        }

        private void bar_TouchDown(object sender, TouchEventArgs e)
        {

        }

        private void bar_TouchMove(object sender, TouchEventArgs e)
        {

        }

        private void bar_TouchUp(object sender, TouchEventArgs e)
        {

        }

        private void MinWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listSelectedChange(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine( (sender as ListBox).SelectedItem );
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {

        }
    }
}
