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

namespace MediaPlayerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.LibraryLocation.Equals("null"))
            {
                var form = new SettingsForm();
                form.Activate();
                form.ShowDialog();
                Console.WriteLine(Properties.Settings.Default.LibraryLocation);
            }
        }
        ~MainWindow()
        {
            Properties.Settings.Default.Save();
        }
    }
}
