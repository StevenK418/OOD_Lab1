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
        List<Album> albums = new List<Album>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Initialize band objects
            InitializeBands();

            //Assign the bands list as the source for the bands listbox.
            LSTBX_Bands.ItemsSource = bands;

            //Initialize album objects
            InitializeAlbums();
        }

        private void LSTBX_Bands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get a reference to the listbox
            ListBox box = (ListBox)sender;

            //Get a reference to the selected band object
            Band band = (Band)box.SelectedItem;

            //Populate text fields with property values of the selected band
            TBLK_Formed.Text = band.YearFormed.ToString();
            TBLK_Members.Text = band.Members;
        }

        /// <summary>
        /// Initializes a series of band objects and adds them to the bands list.
        /// </summary>
        private void InitializeBands()
        {
            //Insntiate two instanced of each band type
            RockBand b1 = new RockBand() { BandName = "The Foo Fighters", YearFormed = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear, Taylor Hawkins, Chris Shifflett, Rami Jaffee" };
            RockBand b2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, Members = "Mick Jagger, Ian Stewart, Dick Taylor, Bill Wyman, Mick Taylor" };

            PopBand b3 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, Members = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand b4 = new PopBand() { BandName = "Green Day", YearFormed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool" };

            IndieBand b5 = new IndieBand() { BandName = "Arctice Monkeys", YearFormed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley" };
            IndieBand b6 = new IndieBand() { BandName = "The Strokes", YearFormed = 1998, Members = "Julian Casablancas, Nick Valensi, Albert Hammond Jr, Nikolai Fraiture, Fabrizia Moretti" };

            //Add the newly instantiated objects to the bands list
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);
        }

        private void InitializeAlbums()
        {
            //Create a new random object
            Random rnd = new Random();

            //Foo Fighter's albums
            Album a1 = new Album("Greatest Hits", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a2 = new Album("One By One", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Rolling Stone's Albums
            Album a3 = new Album("Beggars Banquet", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a4 = new Album("Blue & Lonesome", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Beatles Albums
            Album a5 = new Album("Let it be", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a6 = new Album("Sgt. Pepper's Lonely Heart club band", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Green Day Albums
            Album a7 = new Album("Dookie", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a8 = new Album("American Idiot", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Arctice Monkeys Albums
            Album a9 = new Album("Whatever people say I am, that's what I'm not", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a10 = new Album("Favourite worst nightmare", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Strokes Albums
            Album a11 = new Album("Room on fire", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));
            Album a12 = new Album("The modern age", rnd.Next(1960, 2020), rnd.Next(1000000, 10000000));

            //Add the newly created album instances to the albums list
            albums.Add(a1);
            albums.Add(a2);
            albums.Add(a3);
            albums.Add(a4);
            albums.Add(a5);
            albums.Add(a6);
            albums.Add(a7);
            albums.Add(a8);
            albums.Add(a9);
            albums.Add(a10);
            albums.Add(a11);
            albums.Add(a12);

            //Assign the bands list as the source for the albums listbox.
            LSTBX_Albums.ItemsSource = albums;
        }
    }
}
