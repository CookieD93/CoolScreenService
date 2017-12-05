using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CoolScreenService
{
    public class TemperaturClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public double Temperatur { get; set; }
        [DataMember]
        public string TimeStamp { get; set; }

        public TemperaturClass()
        {
            
        }

        public TemperaturClass(int id, double temperatur, string timeStamp)
        {
            Id = id;
            Temperatur = temperatur;
            TimeStamp = timeStamp;
        }

    }
}