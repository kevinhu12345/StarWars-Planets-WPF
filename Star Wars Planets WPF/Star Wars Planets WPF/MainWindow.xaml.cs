using Class_DLL;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Star_Wars_Planets_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PlanetCollection PlanetCollection = new PlanetCollection();
        private OpenFileDialog fileDialog;
        private string connString;
        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private string sql;

        public MainWindow()
        {
            InitializeComponent();
            //listBoxPlanetNames.SelectionMode = System.Windows.Controls.SelectionMode.Extended;
        }

        //Menu Items
        #region Menu Items
        private void XMLClick(object sender, RoutedEventArgs e)
        {
            //File Dialog
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML files (*.xml)|*.xml";
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Title = "Select XML File";
            var results = fileDialog.ShowDialog();

            if (results == System.Windows.Forms.DialogResult.OK)
            {
                FileStream read = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                DataContractSerializer PersonSerXML = new DataContractSerializer(typeof(PlanetCollection));
                PlanetCollection = (PlanetCollection)PersonSerXML.ReadObject(read);

                PopulateListBoxMENU();
            }
        }

        private void JSONClick(object sender, RoutedEventArgs e)
        {
            //File Dialog
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JSON files (*.json)|*.json";
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Title = "Select XML File";
            var results = fileDialog.ShowDialog();

            if (results == System.Windows.Forms.DialogResult.OK)
            {
                FileStream read = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer PersonSerJSON = new DataContractJsonSerializer(typeof(PlanetCollection));
                PlanetCollection = (PlanetCollection)PersonSerJSON.ReadObject(read);

                PopulateListBoxMENU();
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Star Wars Planet DB\nVersion 1.0\nWritten by Kevin Hu");
        }
        #endregion

        //PlanetName ListBox Selection Event
        private void PlanetNameSelection(object sender, SelectionChangedEventArgs e)
        {
            SqlDataReader readerFilms, readerResidents;
            var t = listBoxPlanetNames.SelectedItem;

            textBoxName.DataContext = t;
            textBoxRotation.DataContext = t;
            textBoxOrbital.DataContext = t;
            textBoxDiameter.DataContext = t;
            textBoxClimate.DataContext = t;
            textBoxGravity.DataContext = t;
            textBoxTerrain.DataContext = t;
            textBoxWater.DataContext = t;
            textBoxPopulation.DataContext = t;
            textBoxCreated.DataContext = t;
            textBoxEdited.DataContext = t;
            textBoxURL.DataContext = t;

            sql = string.Format("SELECT * FROM Films WHERE Name LIKE ('{0}')", textBoxName.Text);
            command = new SqlCommand(sql, connection);
            readerFilms = command.ExecuteReader();
            listBoxFilms.ItemsSource = readerFilms;

            sql = string.Format("SELECT * FROM Residents WHERE Name LIKE ('{0}')", textBoxName.Text);
            command = new SqlCommand(sql, connection);
            readerResidents = command.ExecuteReader();
            listBoxResidents.ItemsSource = readerResidents;
        }

        #region Insert to DB functions
        //Add Film to FilmListBox
        private void AddFilmClick(object sender, RoutedEventArgs e)
        {
            //Don't add if blank
            if (textBoxNewFilm.Text == "")
            {
                System.Windows.MessageBox.Show("You can't add blanks");
                return;
            }
            else
            {
                listBoxFilmsAdd.Items.Add(textBoxNewFilm.Text);
                textBoxNewFilm.Clear();
            }
        }

        //Add Resident to ResidentListBox
        private void AddResidentClick(object sender, RoutedEventArgs e)
        {
            //Dont'add if blank
            if (textBoxNewResident.Text == "")
            {
                System.Windows.MessageBox.Show("You can't add blanks");
                return;
            }
            else
            {
                listBoxResidentsAdd.Items.Add(textBoxNewResident.Text);
                textBoxNewResident.Clear();
            }
        }

        //Insert into DB
        private void InsertClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNameAdd.Text))
            {
                System.Windows.MessageBox.Show("Can't Insert Blank fields to DB");
            }
            else
            {
                sql = string.Format("INSERT INTO Planets Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                    textBoxNameAdd.Text, textBoxRotationAdd.Text, textBoxOrbitalAdd.Text, textBoxDiameterAdd.Text, textBoxClimateAdd.Text, textBoxGravityAdd.Text,
                    textBoxTerrainAdd.Text, textBoxWaterAdd.Text, textBoxPopulationAdd.Text, textBoxCreatedAdd.Text, textBoxEditedAdd.Text, textBoxURLAdd.Text);
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                foreach (string s in listBoxFilmsAdd.Items)
                {
                    sql = string.Format("INSERT INTO Films Values ('{0}', '{1}')", textBoxNameAdd.Text, s);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }

                foreach (string s in listBoxResidentsAdd.Items)
                {
                    sql = string.Format("INSERT INTO Residents Values ('{0}', '{1}')", textBoxNameAdd.Text, s);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }

                ClearAddText();
                RefreshPlanetNameListBox();
            }
        }
        #endregion

        #region Window Load SQL DB Connection
        private void Load(object sender, RoutedEventArgs e)
        {
            ConfigurationBuilder configuationBuilder = new ConfigurationBuilder();
            configuationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configuationBuilder.AddJsonFile("config.json");

            IConfiguration config = configuationBuilder.Build();
            connString = config["ConnectionString"];
            connection = new SqlConnection(connString);
            connection.Open();

            RefreshPlanetNameListBox();
        }
        #endregion

        #region Miscellaneous Methods
        //Clears TextBoxes from Insert Tab
        public void ClearAddText()
        {
            textBoxNameAdd.Clear();
            textBoxRotationAdd.Clear();
            textBoxOrbitalAdd.Clear();
            textBoxDiameterAdd.Clear();
            textBoxClimateAdd.Clear();
            textBoxGravityAdd.Clear();
            textBoxTerrainAdd.Clear();
            textBoxWaterAdd.Clear();
            textBoxPopulationAdd.Clear();
            textBoxCreatedAdd.Clear();
            textBoxEditedAdd.Clear();
            textBoxURLAdd.Clear();

            listBoxFilmsAdd.Items.Clear();
            listBoxResidentsAdd.Items.Clear();
        }

        //Clears the data from all the Tables
        public void ClearALLDBTables()
        {
            sql = string.Format("DELETE FROM Planets DELETE FROM Films DELETE FROM Residents");
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        //Populates the Planet Name ListBox for Menu Items
        public void PopulateListBoxMENU()
        {
            ClearALLDBTables();

            foreach (Planet p in PlanetCollection.Results)
            {
                sql = string.Format("INSERT INTO Planets VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", p.Name, p.Rotational_Period,
                    p.Orbital_Period, p.Diameter, p.Climate, p.Gravity, p.Terrain, p.Surface_Water, p.Population, p.Created, p.Edited, p.Url);
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                foreach (string s in p.Films)
                {
                    sql = string.Format("INSERT INTO Films VALUES ('{0}', '{1}')", p.Name, s);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
                foreach (string s in p.Residents)
                {
                    sql = string.Format("INSERT INTO Residents VALUES ('{0}', '{1}')", p.Name, s);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
            }
            RefreshPlanetNameListBox();
        }

        //Refreshes the Planet Name List Box
        public void RefreshPlanetNameListBox()
        {
            SqlDataReader reader;
            sql = string.Format("SELECT * FROM Planets");
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            listBoxPlanetNames.ItemsSource = reader;
        }
        #endregion
    }
}