using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolScreenService
{
    public class OpskriftClass
    {

        public int Id { get; set; }
        public string Titel { get; set; }
        public string Ingredienser { get; set; }
        public string Opskrift { get; set; }

        public OpskriftClass(int id, string titel, string ingredienser, string opskrift)
        {
            Id = id;
            Titel = titel;
            Ingredienser = ingredienser;
            Opskrift = opskrift;
        }
    }
}