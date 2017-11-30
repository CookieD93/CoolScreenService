﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CoolScreenService
{
    [DataContract]
    public class TemperaturClass
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public double Temperatur { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }

        public TemperaturClass()
        {
            
        }

        public TemperaturClass(int id, double temperatur, DateTime timeStamp)
        {
            Id = id;
            Temperatur = temperatur;
            TimeStamp = timeStamp;
        }

    }
}