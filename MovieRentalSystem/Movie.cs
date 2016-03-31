using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieRentalSystem
{
    public partial class Movie
    {
        // separator for genres and actors by spaces, semicolons, and commas
        private char[] separator = { ' ', ';', ',' };

        private string title;
        private int releaseYear;
        private ArrayList actorsList;
        private ArrayList genreList;

        public Movie(string title, int releaseYear, string newActors, string newGenre)
        {
            this.title = title;
            this.releaseYear = releaseYear;

            actorsList = new ArrayList();
            addActors(newActors);

            genreList = new ArrayList();
            addGenre(newGenre);
        }

        public void addActors(string newActors)
        {
            // using the separator, add each actor/actress (if there are multiple) into arraylist
            string[] actorsResult = newActors.Split(separator);

            foreach (string actor in actorsResult)
                actorsList.Add(actor);
        }

        public void addGenre(string newGenre)
        {
            // using the separator, add each genre (if there are multiple) into arraylist
            string[] genreResult = newGenre.Split(separator);

            foreach (string genre in genreResult)
                genreList.Add(genre);
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }

        public ArrayList ActorsList
        {
            get { return actorsList; }
        }

        public ArrayList GenreList
        {
            get { return genreList; }
        }

        // do a search for movie based on genre
        public bool searchMovieOnGenre(string newGenre)
        {
            if (genreList.Contains(newGenre))
                return true;
            else
                return false;
        }

        // do a search for movie based on actors/actresses
        public bool searchMovieOnActor(string newActor)
        {
            if (actorsList.Contains(newActor))
                return true;
            else
                return false;
        }
    }
}
