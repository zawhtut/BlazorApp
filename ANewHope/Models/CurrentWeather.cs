using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANewHope.Models
{
    public class CurrentConditions
    {
        public CurrentConditions() { }
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public String name { get; set; }
    }
    public class Weather
    {
        public String main { get; set; }
        public String description { get; set; }
        public String icon { get; set; }
    }
    public class Main
    {
        public decimal temp { get; set; }
        public decimal temp_min { get; set; }
        public decimal temp_max { get; set; }
    }
}
