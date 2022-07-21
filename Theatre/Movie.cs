using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; }
        public string Title { get; }
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(Genre movieGenre)
        {
            Genre = movieGenre;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nYear: {Year}\nLength: {Length}\nGenre: {Genre}\nCast: {string.Join(",", Cast)}";
        }

    }
}
