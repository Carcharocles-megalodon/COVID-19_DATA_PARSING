using System;
using System.Collections.Generic;
using System.Text;

namespace DataParsing_OutputCOVID_19
{
    class AffectedCountry
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public uint Confirmed { get; set; }
        public uint Lethal { get; set; }
        public uint Recovered { get; set; }
    }
}
