using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//******************************************************
// File: Person.cs
//
// Purpose: Contains the class definition for Person.
//          Planet.
//
// Written By: Kevin Hu 
//
// Compiler: Visual Studio 2015
//
//******************************************************

namespace Class_DLL
{
    [DataContract]
    public class Person
    {
        //Private Variables
        #region Private Variables
        private string m_Name;
        private string m_Height;
        private string m_Mass;
        private string m_Hair_Color;
        private string m_Skin_Color;
        private string m_Eye_Color;
        private string m_Birth_Year;
        private string m_Gender;
        private string m_Home_World;
        private string m_Created;
        private string m_Edited;
        private string m_Url;
        private string[] films;
        private string[] species;
        private string[] vehicles;
        private string[] starships;
        #endregion

        //Constructors
        #region Constructor
        public Person()
        {
            m_Name = "John";
            m_Height = "5' 7\"";
            m_Mass = "136 lb";
            m_Hair_Color = "Black";
            m_Skin_Color = "White";
            m_Eye_Color = "Blue";
            m_Birth_Year = "1975";
            m_Gender = "Male";
            m_Home_World = "Earth";
            m_Created = "9/9/2015";
            m_Edited = "5/24/2016";
            m_Url = "N/A";
            films = new string[1] { "Star Wars" };
            species = new string[1] { "Humans" };
            vehicles = new string[1] { "Lexus" };
            starships = new string[1] { "Millennial Falcon" };
        }
        #endregion

        //Properties
        #region Propeties
        //****************************************************
        // Method: Name
        //
        // Purpose: Set/Get Name
        //****************************************************
        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }
        //****************************************************
        // Method: Height
        //
        // Purpose: Set/Get Height
        //****************************************************
        [DataMember(Name = "height")]
        public string Height
        {
            get
            {
                return m_Height;
            }
            set
            {
                m_Height = value;
            }
        }
        //****************************************************
        // Method: Mass
        //
        // Purpose: Set/Get Mass
        //****************************************************
        [DataMember(Name = "mass")]
        public string Mass
        {
            get
            {
                return m_Mass;
            }
            set
            {
                m_Mass = value;
            }
        }
        //****************************************************
        // Method: Hair Color
        //
        // Purpose: Set/Get Hair Color
        //****************************************************
        [DataMember(Name = "hair_color")]
        public string Hair_Color
        {
            get
            {
                return m_Hair_Color;
            }
            set
            {
                m_Hair_Color = value;
            }
        }
        //****************************************************
        // Method: Skin Color
        //
        // Purpose: Set/Get Skin Color
        //****************************************************
        [DataMember(Name = "skin_color")]
        public string Skin_Color
        {
            get
            {
                return m_Skin_Color;
            }
            set
            {
                m_Skin_Color = value;
            }
        }
        //****************************************************
        // Method: Eye Color
        //
        // Purpose: Set/Get Eye Color
        //****************************************************
        [DataMember(Name = "eye_color")]
        public string Eye_Color
        {
            get
            {
                return m_Eye_Color;
            }
            set
            {
                m_Eye_Color = value;
            }
        }
        //****************************************************
        // Method: Birth Year
        //
        // Purpose: Set/Get Birth Year
        //****************************************************
        [DataMember(Name = "birth_year")]
        public string Birth_Year
        {
            get
            {
                return m_Birth_Year;
            }
            set
            {
                m_Birth_Year = value;
            }
        }
        //****************************************************
        // Method: Gender
        //
        // Purpose: Set/Get Gender
        //****************************************************
        [DataMember(Name = "gender")]
        public string Gender
        {
            get
            {
                return m_Gender;
            }
            set
            {
                m_Gender = value;
            }
        }
        //****************************************************
        // Method: Homeworld
        //
        // Purpose: Set/Get Homeworld
        //****************************************************
        [DataMember(Name = "homeworld")]
        public string Home_World
        {
            get
            {
                return m_Home_World;
            }
            set
            {
                m_Home_World = value;
            }
        }
        //****************************************************
        // Method: Created
        //
        // Purpose: Set/Get Created
        //****************************************************
        [DataMember(Name = "created")]
        public string Created
        {
            get
            {
                return m_Created;
            }
            set
            {
                m_Created = value;
            }
        }
        //****************************************************
        // Method: Edited
        //
        // Purpose: Set/Get Edited
        //****************************************************
        [DataMember(Name = "edited")]
        public string Edited
        {
            get
            {
                return m_Edited;
            }
            set
            {
                m_Edited = value;
            }
        }
        //****************************************************
        // Method: URL
        //
        // Purpose: Set/Get URL
        //****************************************************
        [DataMember(Name = "url")]
        public string Url
        {
            get
            {
                return m_Url;
            }
            set
            {
                m_Url = value;
            }
        }
        //****************************************************
        // Method: Films
        //
        // Purpose: Set/Get Films
        //****************************************************
        [DataMember(Name = "films")]
        public string[] Films
        {
            get
            {
                return films;
            }
            set
            {
                films = value;
            }
        }
        //****************************************************
        // Method: Species
        //
        // Purpose: Set/Get Species
        //****************************************************
        [DataMember(Name = "species")]
        public string[] Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }
        //****************************************************
        // Method: Vehicles
        //
        // Purpose: Set/Get Vehicles
        //****************************************************
        [DataMember(Name = "vehicles")]
        public string[] Vehicles
        {
            get
            {
                return vehicles;
            }
            set
            {
                vehicles = value;
            }
        }
        //****************************************************
        // Method: Starships
        //
        // Purpose: Set/Get Starships
        //****************************************************
        [DataMember(Name = "starships")]
        public string[] Starships
        {
            get
            {
                return starships;
            }
            set
            {
                starships = value;
            }
        }
        #endregion

        //ToString
        public override string ToString()
        {
            string s = "Name: " + m_Name + "\nHeight: " + m_Height + "\nMass: " + m_Mass + "\nHair Color: " +
                m_Hair_Color + "\nSkin Color: " + m_Skin_Color + "\nEye Color: " + m_Eye_Color + "\nBirth Year: " + m_Birth_Year
                 + "\nGender: " + m_Gender + "\nHome World: " + m_Home_World + "\nCreated: " + m_Created + "\nEdited: " + m_Edited
                  + "\nUrl: " + m_Url + "\nFilms: [ ";
            for (int i = 0; i < films.Length; i++)
            {
                if (i == films.Length - 1)
                {
                    s += films[i];
                }
                else
                {
                    s += films[i] + ", ";
                }
            }
            s += " ]\nSpecies: [ ";
            for (int i = 0; i < species.Length; i++)
            {
                if (i == species.Length - 1)
                {
                    s += species[i];
                }
                else
                {
                    s += films[i] + ", ";
                }
            }
            s += " ]\nVehicles: [ ";
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (i == vehicles.Length - 1)
                {
                    s += vehicles[i];
                }
                else
                {
                    s += vehicles[i] + ", ";
                }
            }
            s += " ]\nStarships: [ ";
            for (int i = 0; i < starships.Length; i++)
            {
                if (i == starships.Length - 1)
                {
                    s += starships[i];
                }
                else
                {
                    s += starships[i] + ", ";
                }
            }
            s += " ]\n\n";
            return s;
        }
    }
}
