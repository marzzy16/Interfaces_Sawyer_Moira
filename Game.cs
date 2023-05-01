using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Sawyer_Moira
{
    class Game : IGenre
    {
        //Creats  automatic properties for ESRB, Genre and Title.
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
     
        /// <summary>
        /// 
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is string! Game on!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
