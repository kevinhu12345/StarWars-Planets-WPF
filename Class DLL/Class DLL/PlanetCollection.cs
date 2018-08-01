using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Class_DLL
{
    [DataContract]
    public class PlanetCollection
    {
        //Private Variables
        #region Private Variables
        private int count;
        private string next;
        private string previous;
        private Planet[] results;
        #endregion

        //Constructors
        #region Constructors
        public PlanetCollection()
        {
            count = 0;
            next = "Yes";
            previous = "No";
            results = new Planet[1];
            results[0] = new Planet();
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
        public Planet[] Results
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
        public Planet this[int i]
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
            foreach (Planet i in results)
            {
                s += i.ToString();
            }
            s += "]\n";
            return s;
        }
    }
}
