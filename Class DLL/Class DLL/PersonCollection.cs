using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//******************************************************
// File: PersonCollection.cs
//
// Purpose: Contains the class definition for PersonCollection.
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
    public class PersonCollection
    {
        //Private Variables
        #region Private Variables
        private int count;
        private string next;
        private string previous;
        private Person[] results;
        #endregion

        //Constructors
        #region Constructors
        public PersonCollection()
        {
            count = 0;
            next = "Yes";
            previous = "No";
            results = new Person[1];
            results[0] = new Person();
        }
        #endregion

        //Properties
        #region Properties
        //****************************************************
        // Method: Count
        //
        // Purpose: Set/Get Count
        //****************************************************
        [DataMember(Name = "count")]
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        //****************************************************
        // Method: Next
        //
        // Purpose: Set/Get Next
        //****************************************************
        [DataMember(Name = "next")]
        public string Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        //****************************************************
        // Method: Previous
        //
        // Purpose: Set/Get Previous
        //****************************************************
        [DataMember(Name = "previous")]
        public string Previous
        {
            get
            {
                return previous;
            }
            set
            {
                previous = value;
            }
        }
        //****************************************************
        // Method: Results
        //
        // Purpose: Set/Get Results
        //****************************************************
        [DataMember(Name = "results")]
        public Person[] Results
        {
            get
            {
                return results;
            }
            set
            {
                results = value;
            }
        }
        #endregion

        //Overload
        #region Overload
        public Person this[int i]
        {
            get
            {
                return results[i];
            }
            set
            {
                results[i] = value;
            }
        }
        #endregion

        //ToString
        public override string ToString()
        {
            string s = "Count: " + count + "\nNext: " + next + "\nPrevious: " + previous + "\nResults:\n[\n";
            foreach (Person i in results)
            {
                s += i.ToString();
            }
            s += "]\n";
            return s;
        }
    }
}
