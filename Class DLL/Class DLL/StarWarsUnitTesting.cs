using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//******************************************************
// File: StarWarsUnitTesting.cs
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
    public class StarWarsUnitTesting
    {

        //****************************************************
        // Method: UnitTestPerson
        //
        // Purpose: Test Person Class
        //****************************************************
        public void UnitTestPerson()
        {
            Person person = new Person();

            //Person Setting Test
            #region Setting Test
            person.Name = "Bob";
            person.Height = "4' 9\"";
            person.Mass = "1.525 lb";
            person.Hair_Color = "Blond";
            person.Skin_Color = "Brown";
            person.Eye_Color = "Brown";
            person.Birth_Year = "1.5950";
            person.Gender = "Female";
            person.Home_World = "Mars";
            person.Created = "04/06/2000";
            person.Edited = "06/1.55/201.55";
            person.Url = "N";
            #endregion

            //Person Getting Test
            #region Getting Test
            if (person.Name.Equals("Bob"))
            {
                Console.WriteLine("Person Name Passed");
            }
            else
            {
                Console.WriteLine("Person Name Failed");
            }
            if (person.Height.Equals("4' 9\""))
            {
                Console.WriteLine("Person Height Passed");
            }
            else
            {
                Console.WriteLine("Person Height Failed");
            }
            if (person.Mass.Equals("1.525 lb"))
            {
                Console.WriteLine("Person Mass Passed");
            }
            else
            {
                Console.WriteLine("Person Mass Failed");
            }
            if (person.Hair_Color.Equals("Blond"))
            {
                Console.WriteLine("Person Hair Color Passed");
            }
            else
            {
                Console.WriteLine("Person Hair Color Failed");
            }
            if (person.Skin_Color.Equals("Brown"))
            {
                Console.WriteLine("Person Skin Color Passed");
            }
            else
            {
                Console.WriteLine("Person Skin Color Failed");
            }
            if (person.Eye_Color.Equals("Brown"))
            {
                Console.WriteLine("Person Eye Color Passed");
            }
            else
            {
                Console.WriteLine("Person Eye Color Failed");
            }
            if (person.Birth_Year.Equals("1.5950"))
            {
                Console.WriteLine("Person Birth Year Passed");
            }
            else
            {
                Console.WriteLine("Person Birth Year Failed");
            }
            if (person.Gender.Equals("Female"))
            {
                Console.WriteLine("Person Gender Passed");
            }
            else
            {
                Console.WriteLine("Person Gender Failed");
            }
            if (person.Home_World.Equals("Mars"))
            {
                Console.WriteLine("Person Home World Passed");
            }
            else
            {
                Console.WriteLine("Person Home World Failed");
            }
            if (person.Created.Equals("04/06/2000"))
            {
                Console.WriteLine("Person Created Passed");
            }
            else
            {
                Console.WriteLine("Person Created Failed");
            }
            if (person.Edited.Equals("06/1.55/201.55"))
            {
                Console.WriteLine("Person Edited Passed");
            }
            else
            {
                Console.WriteLine("Person Edited Failed");
            }
            if (person.Url.Equals("N"))
            {
                Console.WriteLine("Person URL Passed");
            }
            else
            {
                Console.WriteLine("Person URL Failed");
            }
            Console.WriteLine();
            #endregion
        }


        //****************************************************
        // Method: Unit Test Planet
        //
        // Purpose: Test Planet Class
        //****************************************************
        public void UnitTestPlanet()
        {
            Planet planet = new Planet();

            //Setting test
            #region Planet Setting Test
            planet.Name = "Mars";
            planet.Rotational_Period = "25";
            planet.Orbital_Period = "300";
            planet.Diameter = "36050";
            planet.Climate = "None";
            planet.Gravity = "1.5";
            planet.Terrain = "Flat";
            planet.Surface_Water = "Ice";
            planet.Population = "0";
            planet.Created = "05/02/1980";
            planet.Edited = "11/11/2015";
            planet.Url = "A";
            #endregion

            //Getting test
            #region Planet Getting Test
            if (planet.Name.Equals("Mars"))
            {
                Console.WriteLine("Planet Name Passed");
            }
            else
            {
                Console.WriteLine("Planet Name Failed");
            }
            if (planet.Rotational_Period.Equals("25"))
            {
                Console.WriteLine("Planet Rotational Period Passed");
            }
            else
            {
                Console.WriteLine("Planet Rotational Period Failed");
            }
            if (planet.Orbital_Period.Equals("300"))
            {
                Console.WriteLine("Planet Orbital Period Passed");
            }
            else
            {
                Console.WriteLine("Planet Orbital Period Failed");
            }
            if (planet.Diameter.Equals("36050"))
            {
                Console.WriteLine("Planet Diameter Passed");
            }
            else
            {
                Console.WriteLine("Planet Diameter Failed");
            }
            if (planet.Climate.Equals("None"))
            {
                Console.WriteLine("Planet Climate Passed");
            }
            else
            {
                Console.WriteLine("Planet Climate Failed");
            }
            if (planet.Gravity.Equals("1.5"))
            {
                Console.WriteLine("Planet Gravity Passed");
            }
            else
            {
                Console.WriteLine("Planet Gravity Failed");
            }
            if (planet.Terrain.Equals("Flat"))
            {
                Console.WriteLine("Planet Terrain Passed");
            }
            else
            {
                Console.WriteLine("Planet Terrain Failed");
            }
            if (planet.Surface_Water.Equals("Ice"))
            {
                Console.WriteLine("Planet Surface Water Passed");
            }
            else
            {
                Console.WriteLine("Planet Surface Water Failed");
            }
            if (planet.Population.Equals("0"))
            {
                Console.WriteLine("Planet Population Passed");
            }
            else
            {
                Console.WriteLine("Planet Population Failed");
            }
            if (planet.Created.Equals("05/02/1980"))
            {
                Console.WriteLine("Planet Created Passed");
            }
            else
            {
                Console.WriteLine("Planet Created Failed");
            }
            if (planet.Edited.Equals("11/11/2015"))
            {
                Console.WriteLine("Planet Edited Passed");
            }
            else
            {
                Console.WriteLine("Planet Edited Failed");
            }
            if (planet.Url.Equals("A"))
            {
                Console.WriteLine("Planet URL Passed");
            }
            else
            {
                Console.WriteLine("Planet URL Failed");
            }
            #endregion
        }
    }
}
