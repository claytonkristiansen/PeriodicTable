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
using System.Windows.Shapes;
using System.IO;

namespace PeriodicTable
{
    /// <summary>
    /// Interaction logic for Element.xaml
    /// </summary>
    public partial class Element : Window
    {
        int atomicNumber;
        String name;
        String symbol;

        public Element(String atomicName)
        {
            InitializeComponent();
            ElementName.Text = atomicName;

            String localDirectory = Directory.GetCurrentDirectory();
            localDirectory = localDirectory.Substring(0, localDirectory.Length - 24);
            using (StreamReader reader = new StreamReader(localDirectory + "\\Assets\\elementlist.csv"))
            {
                String line0 = reader.ReadLine();
                String line1 = reader.ReadLine();
            }


                elementWebBrowser.Navigate("https://en.wikipedia.org/wiki/" + atomicName);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void ElementWebBrowser_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {

        }
    }
}
