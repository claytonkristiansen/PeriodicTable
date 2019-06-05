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
using System.IO;

namespace PeriodicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Element> elements = new List<Element>();
        private ElementWindow currElementWindow;

        internal static List<Element> Elements { get => elements; set => elements = value; }

        private Element OpenElementWindow(Element element)
        {
            if(currElementWindow != null)
            {
                currElementWindow.Close();
            }
            currElementWindow = new ElementWindow(element);
            currElementWindow.Show();
            return element;
        }

        private List<Element> ParseElementscsv(String filePath)
        {
            List<Element> elementList = new List<Element>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] info = line.Split(',');

                    Convert.ToInt32(info[0]);
                    float.Parse(info[3]);
                    Convert.ToInt32(info[4]);
                    Convert.ToInt32(info[5]);
                    Convert.ToInt32(info[6]);
                    Convert.ToInt32(info[7]);
                    Convert.ToInt32(info[8]);
                    bool a = info[10] != "";
                    bool b = info[11] != "";
                    bool c = info[12] != "";
                    bool d = info[13] != "";
                    bool e = info[14] != "";
                    float.Parse(info[16]);
                    float.Parse(info[17]);
                    float.Parse(info[18]);
                    float.Parse(info[20]);
                    float.Parse(info[21]);
                    Convert.ToInt32(info[22]);
                    Convert.ToInt32(info[24]);
                    float.Parse(info[25]);
                    Convert.ToInt32(info[26]);
                    Convert.ToInt32(info[27]);

                    Element element = new Element(
                        Convert.ToInt32(info[0]),
                        info[1],
                        info[2],
                        float.Parse(info[3]),
                        Convert.ToInt32(info[4]),
                        Convert.ToInt32(info[5]),
                        Convert.ToInt32(info[6]),
                        Convert.ToInt32(info[7]),
                        Convert.ToInt32(info[8]),
                        info[9],
                        info[10] != "",
                        info[11] != "",
                        info[12] != "",
                        info[13] != "",
                        info[14] != "",
                        info[15],
                        float.Parse(info[16]),
                        float.Parse(info[17]),
                        float.Parse(info[18]),
                        info[19],
                        float.Parse(info[20]),
                        float.Parse(info[21]),
                        Convert.ToInt32(info[22]),
                        info[23],
                        Convert.ToInt32(info[24]),
                        float.Parse(info[25]),
                        Convert.ToInt32(info[26]),
                        Convert.ToInt32(info[27]));
                    elementList.Add(element);
                }
            }
            return elementList;
        }

        public MainWindow()
        {
            InitializeComponent();
            String localDirectory = Directory.GetCurrentDirectory();
            localDirectory = localDirectory.Substring(0, localDirectory.Length - 24);
            Elements = ParseElementscsv(localDirectory + "\\Assets\\PeriodicTableOfElements.csv");
            int i = 0;


        }


        private void Element_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            for(int i = 0; i < elements.Count; i++)
            {
                if(elements.ElementAt(i).elementName.Equals(button.Name))
                {
                    OpenElementWindow(elements.ElementAt(i));
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.NumPad1)
            {

            }
        }
    }
}
