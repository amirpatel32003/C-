using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public class Theatre
    {
        private List<Show> shows = new List<Show>();
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
        }
        //used to add new show into collection
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        //display details of all shows
        public void PrintShows()
        {
            foreach (Show currentShow in shows)
            {
                Console.WriteLine(currentShow);
            }
        }
        //takes genre as an argument and display shows containing this genre
        public void PrintShows(Genre genre)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        //takes one argument day and display all shows scheduled on that day
        public void PrintShows(Day day)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Day.Equals(day))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        //takes one argument as time and display all shows scheduled on that time
        public void PrintShows(Time time)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Time == time)
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        //takes one argument as name of actor and display shows that actor appear in
        public void PrintShows(string actor)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        //takes 2 arguments day and time and display shows scheduled on that time and day
        public void PrintShows(Day day, Time time)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Day.Equals(day) && currentShow.Time == time)
                {
                    Console.WriteLine(currentShow);
                }
            }

        }
    }
}
