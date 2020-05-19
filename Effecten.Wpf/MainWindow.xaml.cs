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
using Beleggingen.Lib.Entities;
using Beleggingen.Lib.Services;

namespace Effecten.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeheerEffecten beheerEffecten;
        BeheerPortefeuille beheerPortefeuille;
        Inschrijving huidigeInschrijving;

        enum DataSources
        {
            MockData, TextFile, Database
        }


        public MainWindow()
        {
            InitializeComponent();
            BepaalData(DataSources.MockData);

        }

        void BepaalData(DataSources dataSource)
        {


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grdTak21.Margin = grdFonds.Margin;
        }


        private void lstInschrijvingen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }
    }
}
