using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Web;

namespace CoolScreenService
{
    public class NoteClass
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titel { get; set; }
        [DataMember]
        public string Note { get; set; }


        public NoteClass()
        {
            
        }

        public NoteClass(int id, string titel, string note)
        {
            Id = id;
            Titel = titel;
            Note = note;
        }
    }
}