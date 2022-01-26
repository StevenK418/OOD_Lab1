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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Band> bands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Insntiate two instanced of each band type
            RockBand b1 = new RockBand() {BandName = "The Foo Fighters", YearFormed = 1994, Members="Dave Grohl, Nate Mendel, Pat Smear, Taylor Hawkins, Chris Shifflett, Rami Jaffee" };
            RockBand b2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, Members = "Mick Jagger, Ian Stewart, Dick Taylor, Bill Wyman, Mick Taylor" };

            PopBand b3 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, Members = "John Lennon, Paul McCartney, Genorge Harrison, Ringo Starr" };
            PopBand b4 = new PopBand() { BandName = "Green Day", YearFormed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool" };

            IndieBand b5 = new IndieBand() { BandName = "Arctice MOnkeys", YearFormed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley" };
            IndieBand b6 = new IndieBand() { BandName = "The Strokes", YearFormed = 1998, Members = "Julian Casablancas, Nick Valensi, Albert Hammond Jr, Nikolai Fraiture, Fabrizia Moretti" };

            //Add the newly instantiated objects to the bands list
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            //Assign the bands list as the source for the bands listbox.
            LSTBX_Bands.ItemsSource = bands;
        }
    }
}
