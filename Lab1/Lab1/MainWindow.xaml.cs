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
        string[] genres = { "All", "Rock", "Pop", "Indie" };

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

            //Assign the genres array as datasource to the Genre dropdown
            CMBX_Genre.ItemsSource = genres;
            CMBX_Genre.SelectedIndex = 0;
        }

        private void LSTBX_Bands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get a reference to the listbox
            ListBox box = (ListBox)sender;

            //Get a reference to the selected band object
            Band band = (Band)box.SelectedItem;

            //Check if the selected band exists before accessing data
            if (band != null)
            {
                //Populate text fields with property values of the selected band
                TBLK_Formed.Text = band.YearFormed.ToString();
                TBLK_Members.Text = band.Members;

                //Show the band's albums in the albums list box
                ShowAlbums(band);
            }
            else
            {
                //Clear text fields of property values if no band is selected
                TBLK_Formed.Text = "";
                TBLK_Members.Text = "";
            }
        }
        private void CMBX_Genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get a reference to the sending dropdown object
            ComboBox box = (ComboBox)sender;
            //Get a reference to the selected band type
            string type = (string)box.SelectedItem;

            //Filter the displayed bands by the selected type
            FilterBands(type);
        }

        /// <summary>
        /// Assigns a given band's albums list as the 
        /// datasource for the albums listbox.
        /// </summary>
        /// <param name="band"></param>
        private void ShowAlbums(Band band)
        {
            LSTBX_Albums.ItemsSource = band.AlbumList;
        }

        /// <summary>
        /// Initializes a series of band objects and adds them to the bands list.
        /// </summary>
        private void InitializeBands()
        {
            //Insntiate two instanced of each band type
            RockBand b1 = new RockBand() { BandName = "The Foo Fighters", YearFormed = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear, Taylor Hawkins, Chris Shifflett, Rami Jaffee", BandType="Rock"};
            RockBand b2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, Members = "Mick Jagger, Ian Stewart, Dick Taylor, Bill Wyman, Mick Taylor", BandType = "Rock" };

            PopBand b3 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, Members = "John Lennon, Paul McCartney, George Harrison, Ringo Starr", BandType = "Pop" };
            PopBand b4 = new PopBand() { BandName = "Green Day", YearFormed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool", BandType = "Pop" };

            IndieBand b5 = new IndieBand() { BandName = "Arctice Monkeys", YearFormed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley", BandType="Indie" };
            IndieBand b6 = new IndieBand() { BandName = "The Strokes", YearFormed = 1998, Members = "Julian Casablancas, Nick Valensi, Albert Hammond Jr, Nikolai Fraiture, Fabrizia Moretti", BandType="Indie"};

            //Add the newly instantiated objects to the bands list
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            //Sort the bands
            bands.Sort();
        }

        /// <summary>
        /// Initailizes a series of new Album objects
        /// and assigns them to the appropriate band object
        /// </summary>
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

            //Add each album instance to it's corresponding bands
            if(bands.Count > 0)
            {
                bands[0].AlbumList.Add(a1);
                bands[0].AlbumList.Add(a2);

                bands[1].AlbumList.Add(a3);
                bands[1].AlbumList.Add(a4);

                bands[2].AlbumList.Add(a5);
                bands[2].AlbumList.Add(a6);

                bands[3].AlbumList.Add(a7);
                bands[3].AlbumList.Add(a8);

                bands[4].AlbumList.Add(a9);
                bands[4].AlbumList.Add(a10);

                bands[5].AlbumList.Add(a11);
                bands[5].AlbumList.Add(a12);
            }
        }

        /// <summary>
        /// Filters the bands shown in the bands listbox based
        /// on a given band type.
        /// </summary>
        /// <param name="type"></param>
        private void FilterBands(string type)
        {
            List<RockBand> rockBands = new List<RockBand>();
            List<PopBand> popBands = new List<PopBand>();
            List<IndieBand> indieBands = new List<IndieBand>();
            
            foreach (var band in bands)
            {
                if (band.BandType == "Rock")
                {
                    rockBands.Add((RockBand)band);
                }
                else if(band.BandType == "Pop")
                {
                    popBands.Add((PopBand)band);
                }
                else if (band.BandType == "Indie")
                {
                    indieBands.Add((IndieBand)band);
                }
            }

            //Check the type that's passed and assign the appropriate list as the datasource for the bands listbox
            switch (type)
            {
                case "Rock":
                    //Show Rock Bands Only
                    LSTBX_Bands.ItemsSource = rockBands;
                    break;
                case "Pop":
                    //Show Pop Bands Only
                    LSTBX_Bands.ItemsSource = popBands;
                    break;
                case "Indie":
                    //Show Indie Bands Only
                    LSTBX_Bands.ItemsSource = indieBands;
                    break;
                default:
                    //Show all bands
                    LSTBX_Bands.ItemsSource = bands;
                    break;
            }
        }

    }
}
