using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Sawyer_Moira
{
    interface IGenre
    {

        //automatic properties for ESRB, Genre and Title.
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe();
    }
}
