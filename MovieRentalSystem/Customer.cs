using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MovieRentalSystem
{
    public partial class Customer
    {
        

        private string fullName;
        private string streetAddress;
        private string cityState;
        private int zipcode;
        private int age;

        public Customer(string fullName, string streetAddress, string cityState, int zipcode, DateTime DOB)
        {
            this.fullName = fullName;
            this.streetAddress = streetAddress;
            this.cityState = cityState;
            this.zipcode = zipcode;
            

            // calculate a person's age
            DateTime today = DateTime.Today;
            age = today.Year - DOB.Year;
            if (today < DOB.AddYears(age))
                age--;

        }

    
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string CityState
        {
            get { return cityState; }
            set { cityState = value; }
        }

        public int ZipCode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public int Age
        {
            get { return age; }
        }


    }
}
