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

namespace MyTheme1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MyTheme1.dsAuswahl dsAuswahl = ((MyTheme1.dsAuswahl)(this.FindResource("dsAuswahl")));
            // Load data into the table AUSWAHLPOS. You can modify this code as needed.
            MyTheme1.dsAuswahlTableAdapters.AUSWAHLPOSTableAdapter dsAuswahlAUSWAHLPOSTableAdapter = new MyTheme1.dsAuswahlTableAdapters.AUSWAHLPOSTableAdapter();
            dsAuswahlAUSWAHLPOSTableAdapter.Fill(dsAuswahl.AUSWAHLPOS);
            System.Windows.Data.CollectionViewSource aUSWAHLPOSViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("aUSWAHLPOSViewSource")));
            aUSWAHLPOSViewSource.View.MoveCurrentToFirst();
        }
    }
}
