﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt
{
    public class Bil
    {
        public int ID { get; set; }
        public DateTime Oprettelsesdato { get; set; }
        public string Maerke { get; set; }
        public string Model { get; set; }
        public int Aargang { get; set; }
        public string Registreringsnummer { get; set; }
        public int Km { get; set; }
        public int BraendstoftypeID { get; set; }
        public int KundeID { get; set; }
    }
}