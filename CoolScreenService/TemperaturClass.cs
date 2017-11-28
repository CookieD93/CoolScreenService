using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolScreenService
{
    public class TemperaturClass
    {
        public int Id { get; set; }
        public double Temperatur { get; set; }
        public DateTime TimeStamp { get; set; }

        public TemperaturClass(int id, double temperatur, DateTime timeStamp)
        {
            Id = id;
            Temperatur = temperatur;
            TimeStamp = timeStamp;
        }

    }
}