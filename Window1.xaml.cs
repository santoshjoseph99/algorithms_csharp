using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

namespace draw_network
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private Network MyNetwork = new Network();

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.DefaultExt = ".net";
                dialog.Filter = "Network Files|*.net|All Files|*.*";

                // Display the dialog.
                bool? result = dialog.ShowDialog();
                if (result == true)
                {
                    // Open the network.
                    MyNetwork.LoadFromFile(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MyNetwork = new Network();
            }

            // Display the network.
            DrawNetwork();
        }

        private void DrawNetwork()
        {
            // Remove any previous drawing.
            

            // Make the network draw itself.
            
        }

        private void ExitCommand_Executed(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
