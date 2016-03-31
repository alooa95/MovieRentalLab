using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    public partial class Transaction
    {
        private ArrayList transactionList;

        public Transaction(DateTime dateTime, Customer newCustomer, Movie newMovie)
        {
            transactionList = new ArrayList();
            // save the date
            transactionList.Add(dateTime.ToString("MM-dd-yyyy"));
            // save the time
            transactionList.Add(dateTime.ToString("hh:mm tt"));
            transactionList.Add(newCustomer.FullName);
            transactionList.Add(newMovie.Title);
        }
    }
}
