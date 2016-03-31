using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieRentalSystem
{
    public partial class MovieRentalSystem
    {
        
        List<Movie> moviesArray;
        List<Customer> customerArray;


        // text file locator and string to hold the movie information
        // need to change path to match each machine use the text file
        private string path = "MovieList.txt";


        public MovieRentalSystem()
        {
            moviesArray = new List<Movie>();
            customerArray = new List<Customer>();

        }

        public bool movieOnSystem(Movie newMovie)
        {
            // We can use "foreach" to iterate over the movies stored in the moviesArray
            foreach (Movie movie in moviesArray)
            {
                // Inside the loop, we compare the names
                if (movie.Title == newMovie.Title) return true;
            }
            return false;
        }

        public void loadMovieFile()
        {
             System.IO.StreamReader file = new System.IO.StreamReader("MovieList.txt");
             string line;
             string[] values;
             while (file.EndOfStream != true)
             {
                line =  file.ReadLine();
                values = line.Split('|');

                if (values.Length != 0)
                {


                    Movie aMovie = new Movie(values[0] , int.Parse(values[1]) , values[2] , values[3]);
                    moviesArray.Add(aMovie);
                }
             }
        }
        public string addMovieToSystem(Movie newMovie)
        {
            // check for movies with the same title, but different release date
            if (movieOnSystem(newMovie) == false)
            {
                moviesArray.Add(newMovie);
                return "New movie has been added to the system.";
            }
            else
                return "Movie is already in the system.";
        }

        public void saveMoviesFile()
        {
            string movieInfo;
            foreach (Movie newMovie in moviesArray)
            {

                // add the new movie information into a string
                movieInfo = newMovie.Title + " | " + newMovie.ReleaseYear + " | ";
                foreach (string actor in newMovie.ActorsList)
                {
                    if (newMovie.ActorsList.Count == 1)
                        movieInfo += actor.ToString();
                    else
                    {
                        movieInfo += actor.ToString() + ", ";
                    }
                }

                movieInfo += " | ";

                foreach (string genre in newMovie.GenreList)
                {
                    if (newMovie.GenreList.Count == 1)
                        movieInfo += genre.ToString();
                    else
                        movieInfo += genre.ToString() + ", ";
                }
                movieInfo += " |";

                // removes extra commas and replace them with something else
                // you can try to comment out each line to see what happens if you still don't understand :)
                movieInfo = movieInfo.Replace(", ,", ",");
                movieInfo = movieInfo.Replace(",  ", " ");
                movieInfo = movieInfo.Replace(", |", " |");

                movieInfo += "\n";

                // add new movie to text file using streamswriter with the path to the text file
                using (StreamWriter writer = new StreamWriter(path, true))
                    writer.WriteLine(movieInfo);
            }
        }

        // still need to figure out after finishing the add button
        public void searchMovie(Movie newMovie)
        {

        }


        //CUSTOEMR STUFF

        public bool customerOnSystem(Customer newCustomer)
        {
            foreach (Customer customer in customerArray)
            {
                if (customer.FullName == newCustomer.FullName) return true;
            }
            return false;
        }
        public void loadCustomer()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("CustomerList.txt");
            string line;
            string[] values;
            while (file.EndOfStream != true)
            {
                line = file.ReadLine();
                values = line.Split('|');

                if (values.Length != 0)
                {
                    Customer someCustomer = new Customer(values[0], values[1], values[2], int.Parse(values[3]), DateTime.Parse(values[4]));
                    customerArray.Add(someCustomer);
                }
            }
        }

        public string addCustomerToSystem(Customer newCustomer)
        {
            if (customerOnSystem(newCustomer) == false)
            {
                customerArray.Add(newCustomer);
                return "New Customer has been added to the system!";
            }
            else
                return "Customer is already in the system.";
        }

        public void saveCustomerFile()
       {
           string customerInfo;
           foreach (Customer newCustomer in customerArray)
           {

               customerInfo = newCustomer.FullName + " | " + newCustomer.StreetAddress + " | " + newCustomer.CityState + " | "
                            + newCustomer.ZipCode + " | " + newCustomer.Age;
          
               customerInfo = customerInfo.Replace(", ,", ",");
               customerInfo = customerInfo.Replace(",  ", " ");
               customerInfo = customerInfo.Replace(", |", " |");

               customerInfo += "\n";

               // add new movie to text file using streamswriter with the path to the text file
               using (StreamWriter writer = new StreamWriter(path, true))
                   writer.WriteLine(customerInfo);
           }
       }
       



    }
}
