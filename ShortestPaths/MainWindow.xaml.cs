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

namespace ShortestPaths
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnNetwork1(object sender, RoutedEventArgs e)
        {
            var network1 = new Network();

            network1.LoadFromFile("network1.txt");

            network1.SaveIntoFile("network1-saved.txt");

            if(Network.ValidateNetwork(network1, "network1-saved.txt"))
            {
                MessageBox.Show("Network is valid");
            } else
            {
                MessageBox.Show("Network is to valid");
            }
        }
        private void OnNetwork2(object sender, RoutedEventArgs e) {
            var network1 = new Network();

            network1.LoadFromFile("network2.txt");

            network1.SaveIntoFile("network2-saved.txt");

            if (Network.ValidateNetwork(network1, "network2-saved.txt"))
            {
                MessageBox.Show("Network is valid");
            }
            else
            {
                MessageBox.Show("Network is to valid");
            }
        }

        private void OnNetwork3(object sender, RoutedEventArgs e) {
            var network1 = new Network();

            network1.LoadFromFile("network3.txt");

            network1.SaveIntoFile("network3-saved.txt");

            if (Network.ValidateNetwork(network1, "network3-saved.txt"))
            {
                MessageBox.Show("Network is valid");
            }
            else
            {
                MessageBox.Show("Network is to valid");
            }
        }

    }
}
