using System;
using System.Collections.Generic;
namespace Lab11_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("This list has 10 movies in it.\n Which movie genre would you like to see the list for? We have action, comedy, horror, and sports! Type in the genre type and press enter.");
                bool cont2 = true;
                string genreChoice = "";
                while(cont2)
                {
                    genreChoice = Console.ReadLine().ToLower();
                    if(genreChoice == "action"|| genreChoice == "comedy" || genreChoice == "horror" || genreChoice == "sports")
                    {
                        cont2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid genre, please give a valid response and press enter.");
                    }

                }
                
                List<Movie> genreList = new List<Movie>
                {
                new Movie("Avengers", "action"),
                new Movie("Batman", "action"),
                new Movie("Step Brothers", "comedy"),
                new Movie("Taladega Nights", "comedy"),
                new Movie("Jeepers Creepers", "horror"),
                new Movie("Moneyball", "sports"),
                new Movie("Airplane", "comedy"),
                new Movie("Star Wars: The empire strikes back", "action"),
                new Movie("Lord of the Rings: The twin towers", "action"),
                new Movie("The Hobbit", "action"),
                new Movie("Angels in the outfield", "sports")
                };
                List<string> selectedMovie = new List<string> { };
                foreach (Movie movie in genreList)
                {
                    if (movie.GetCategory() == genreChoice)
                    {
                        selectedMovie.Add(movie.GetTitle());
                    }
                }
                selectedMovie.Sort();
                foreach (string h in selectedMovie)
                {
                    Console.WriteLine(h);
                }
                Console.WriteLine("Would you like to run this program again?(y/n)");
                cont = Continue.ContinueOrNot();
            }
        }
    }
}

