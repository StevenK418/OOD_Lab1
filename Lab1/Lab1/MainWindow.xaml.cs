/*
 * Name:            Steven Kelly
 * Student ID:      S00200293
 * Date:            28/01/2022
 * Lab:             Lab1 - Bands WPF
 * Question:        Lab 1
 * Description:     "Create a XAML interface to manage bands"
 * Developer note:  "Band ata File can be found locally at <Project Folder>/bin/Debug/".
 * Github page:     https://github.com/StevenK418/OOD_Lab1
 * Git Clone:       https://github.com/StevenK418/OOD_Lab1.git
 * 
 */


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

            //Clear any possible error messages from the UI
            TBLK_ErrorMessage.Text = "";
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

            IndieBand b5 = new IndieBand() { BandName = "Arctic Monkeys", YearFormed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley", BandType="Indie" };
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
            Album a1 = new Album("Greatest Hits", new DateTime(rnd.Next(1960, 2020), 01,01), rnd.Next(1000000, 10000000));
            Album a2 = new Album("One By One", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

           //Rolling Stone's Albums
            Album a3 = new Album("Beggars Banquet", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));
            Album a4 = new Album("Blue & Lonesome", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

            //Beatles Albums
            Album a5 = new Album("Let it be", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));
            Album a6 = new Album("Sgt. Pepper's Lonely Heart club band", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

            //Green Day Albums
            Album a7 = new Album("Dookie", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));
            Album a8 = new Album("American Idiot", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

            //Arctice Monkeys Albums
            Album a9 = new Album("Whatever people say I am, that's what I'm not", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));
            Album a10 = new Album("Favourite worst nightmare", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

            //Strokes Albums
            Album a11 = new Album("Room on fire", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));
            Album a12 = new Album("The modern age", new DateTime(rnd.Next(1960, 2020), 01, 01), rnd.Next(1000000, 10000000));

            //Add each album instance to it's corresponding band
            if(bands.Count > 0)
            {
                foreach (Band band in bands)
                {
                    if (band.BandName== "The Foo Fighters")
                    {
                        band.AlbumList.Add(a1);
                        band.AlbumList.Add(a2);
                    }
                    else if(band.BandName == "The Rolling Stones")
                    {
                        band.AlbumList.Add(a3);
                        band.AlbumList.Add(a4);
                    }
                    else if (band.BandName == "The Beatles")
                    {
                        band.AlbumList.Add(a5);
                        band.AlbumList.Add(a6);
                    }
                    else if (band.BandName == "Green Day")
                    {
                        band.AlbumList.Add(a7);
                        band.AlbumList.Add(a8);
                    }
                    else if (band.BandName == "Arctic Monkeys")
                    {
                        band.AlbumList.Add(a9);
                        band.AlbumList.Add(a10);
                    }
                    else if (band.BandName == "The Strokes")
                    {
                        band.AlbumList.Add(a11);
                        band.AlbumList.Add(a12);
                    }
                }
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

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            //Create a new filemanager instance
            FileManager fileManager = new FileManager();

            //Create a list to store all band data
            List<string> bandData = new List<String>();

            //Get a reference to the currently selected band
            Band selectedBand = (Band)LSTBX_Bands.SelectedItem;

            //If a band is selected, collect the data
            if (selectedBand != null)
            {
                //Add the data for the band to the bandData list
                bandData.Add("Name:" + selectedBand.BandName);
                bandData.Add("Genre: " + selectedBand.BandType);
                bandData.Add("Year Formed: " + selectedBand.YearFormed.ToString());

                //Add an Albums header to the file
                bandData.Add("\nAlbums:");

                //Get the Albums for the selected Band
                foreach (Album album in selectedBand.AlbumList)
                {
                   
                    //Add each album data field to the file
                    bandData.Add("Name: " + album.Name);
                    bandData.Add("Released: " + album.Released.Year.ToString());
                    bandData.Add("Years since release: " + album.YearsSinceRelease.ToString());
                }

                //Pass the bandData info to the filemanager to write to file.
                fileManager.WriteTextFile(bandData);

                //Show a success message if file is saved! 
                TBLK_ErrorMessage.Text = "File saved Successfully!";
            }
            else
            {
                //If no band is selected, show an error message
                TBLK_ErrorMessage.Text = "Error: No Band Selected! Please selct a band and try again!";
            }
        }
    }
}
