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

namespace PeriodicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Element currElementWindow;
        private String OpenElementWindow(String elementName)
        {
            if(currElementWindow != null)
            {
                currElementWindow.Close();
            }
            currElementWindow = new Element(elementName);
            currElementWindow.Show();
            return elementName;
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Element_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            OpenElementWindow(button.Name);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.NumPad1)
            {

            }
        }
    }
}