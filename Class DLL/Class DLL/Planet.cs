using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//******************************************************
// File: Planet.cs
//
// Purpose: Contains the class definition for Planet.
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
    public class Planet
    {
        //Private Variables
        #region Private Variables
        private string m_Name;
        private string m_Rotational_Period;
        private string m_Orbital_Period;
        private string m_Diameter;
        private string m_Climate;
        private string m_Gravity;
        private string m_Terrain;
        private string m_Surface_Water;
        private string m_Population;
        private string m_Created;
        private string m_Edited;
        private string m_Url;
        private string[] films;
        private string[] residents;
        #endregion

        //Constructors
        #region Constructors
        public Planet()
        {
            m_Name = "Earth";
            m_Rotational_Period = "24";
            m_Orbital_Period = "365";
            m_Diameter = "45621";
            m_Climate = "Seasonal";
            m_Gravity = "1";
            m_Terrain = "Varied";
            m_Surface_Water = "Salt Water";
            m_Population = "7000000000";
            m_Created = "04/25/1968";
            m_Edited = "01/06/2014";
            m_Url = "N/A";
            films = new string[1] { "Star Wars" };
            residents = new string[1] { "Darth Vader" };
        }
        #endregion

        //Properties
        #region Properties
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
        // Method: Rotational Period
        //
        // Purpose: Set/Get Rotational Period
        //****************************************************
        [DataMember(Name = "rotation_period")]
        public string Rotational_Period
        {
            get
            {
                return m_Rotational_Period;
            }
            set
            {
                m_Rotational_Period = value;
            }
        }
        //****************************************************
        // Method: Orbital Period
        //
        // Purpose: Set/Get Orbital Period
        //****************************************************
        [DataMember(Name = "orbital_period")]
        public string Orbital_Period
        {
            get
            {
                return m_Orbital_Period;
            }
            set
            {
                m_Orbital_Period = value;
            }
        }
        //****************************************************
        // Method: Diameter
        //
        // Purpose: Set/Get Diameter
        //****************************************************
        [DataMember(Name = "diameter")]
        public string Diameter
        {
            get
            {
                return m_Diameter;
            }
            set
            {
                m_Diameter = value;
            }
        }
        //****************************************************
        // Method: Climate
        //
        // Purpose: Set/Get Climate
        //****************************************************
        [DataMember(Name = "climate")]
        public string Climate
        {
            get
            {
                return m_Climate;
            }
            set
            {
                m_Climate = value;
            }
        }
        //****************************************************
        // Method: Gravity
        //
        // Purpose: Set/Get Gravity
        //****************************************************
        [DataMember(Name = "gravity")]
        public string Gravity
        {
            get
            {
                return m_Gravity;
            }
            set
            {
                m_Gravity = value;
            }
        }
        //****************************************************
        // Method: Terrain
        //
        // Purpose: Set/Get Terrain
        //****************************************************
        [DataMember(Name = "terrain")]
        public string Terrain
        {
            get
            {
                return m_Terrain;
            }
            set
            {
                m_Terrain = value;
            }
        }
        //****************************************************
        // Method: Surface Water
        //
        // Purpose: Set/Get Surface Water
        //****************************************************
        [DataMember(Name = "surface_water")]
        public string Surface_Water
        {
            get
            {
                return m_Surface_Water;
            }
            set
            {
                m_Surface_Water = value;
            }
        }
        //****************************************************
        // Method: Population
        //
        // Purpose: Set/Get Population
        //****************************************************
        [DataMember(Name = "population")]
        public string Population
        {
            get
            {
                return m_Population;
            }
            set
            {
                m_Population = value;
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
        // Method: Residents
        //
        // Purpose: Set/Get Residents
        //****************************************************
        [DataMember(Name = "residents")]
        public string[] Residents
        {
            get
            {
                return residents;
            }
            set
            {
                residents = value;
            }
        }
        #endregion

        //ToString
        public override string ToString()
        {
            string s = "Name: " + m_Name + "\nRotational Period: " + m_Rotational_Period +
            "\nOrbital Period: " + m_Orbital_Period + "\nDiameter: " + m_Diameter +
            "\nClimate: " + m_Climate + "\nGravity: " + m_Gravity +
            "\nTerrain: " + m_Terrain + "\nSurface Water: " + m_Surface_Water +
            "\nPopulation: " + m_Population + "\nCreated: " + m_Created +
            "\nEdited: " + m_Edited + "\nURL: " + m_Url + "\nFilms: [ ";

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
            s += " ]\nResidents: [ ";
            for (int i = 0; i < residents.Length; i++)
            {
                if (i == residents.Length - 1)
                {
                    s += residents[i];
                }
                else
                {
                    s += residents[i] + ", ";
                }
            }
            s += " ]\n\n";
            return s;
        }
    }
}
