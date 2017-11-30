using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CoolScreenService
{
    [DataContract]
    public class OpskriftClass
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titel { get; set; }
        [DataMember]
        public string Ingredienser { get; set; }
        [DataMember]
        public string Opskrift { get; set; }


        public OpskriftClass()
        {
            
        }
        public OpskriftClass(int id, string titel, string ingredienser, string opskrift)
        {
            Id = id;
            Titel = titel;
            Ingredienser = ingredienser;
            Opskrift = opskrift;
        }
    }
}