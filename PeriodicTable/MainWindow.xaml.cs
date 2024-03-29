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
using System.IO;
using System.Diagnostics;

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
            foreach(object o1 in LogicalTreeHelper.GetChildren(MainCanvas))
            {
                Element thisElement = new Element();
                if (o1.GetType().Name == "Button")
                {
                    Button button = o1 as Button;
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements.ElementAt(i).elementName.Equals(button.Name))
                        {
                            thisElement = elements.ElementAt(i);
                        }
                    }

                    foreach (object o in LogicalTreeHelper.GetChildren(o1 as System.Windows.DependencyObject))
                    {
                        Type type = o.GetType();
                        //if(o.GetType() is Grid)
                        //{
                        foreach (object o2 in LogicalTreeHelper.GetChildren(o as System.Windows.DependencyObject))
                        {
                            if (o2.GetType().Name == "TextBlock")
                            {
                                TextBlock textBlock = o2 as TextBlock;
                                if (textBlock.Tag as String == "SymbolButton")
                                {
                                    textBlock.Text = thisElement.symbol;
                                }
                                if (textBlock.Tag as String == "AtomicNumberButton")
                                {
                                    textBlock.Text = thisElement.atomicNumber.ToString();
                                }
                                if (textBlock.Tag as String == "AtomicMassButton")
                                {
                                    textBlock.Text = thisElement.atomicMass.ToString();
                                }
                            }
                        }

                    }
                }

                
            }
        }


        private void Element_Click(object sender, RoutedEventArgs e)
        {
            List<FrameworkElement> logicalElements = new List<FrameworkElement>();
            GetLogicalElements(sender, logicalElements);
            Button button = sender as Button;
            for(int i = 0; i < elements.Count; i++)
            {
                if(elements.ElementAt(i).elementName.Equals(button.Name))
                {
                    OpenElementWindow(elements.ElementAt(i));
                }
            }
        }

        private void GetLogicalElements(object parent, List<FrameworkElement> logicalElements)
        {
            if (parent == null) return;

            if (parent.GetType().IsSubclassOf(typeof(FrameworkElement)))
                logicalElements.Add((FrameworkElement)parent);

            DependencyObject doParent = parent as DependencyObject;

            if (doParent == null) return;

            foreach (object child in LogicalTreeHelper.GetChildren(doParent))
            {
                GetLogicalElements(child, logicalElements);
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
