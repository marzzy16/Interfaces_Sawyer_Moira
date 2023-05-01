using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Sawyer_Moira
{
    class Movie : IGenre
    {
        //Creats  automatic properties for ESRB, Genre and Title.
        public string Esrb { get; set; }
        public string Genre { get; set; } 
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// A public method that prints the Movie String.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh!");
        }

        /// <summary>
        ///  A public method that prints the Movie String.
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}!";
        }
    }
}
