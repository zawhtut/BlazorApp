using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANewHope.Models
{
    public class Alert
    {
        public String type { get; set; }
        public String title { get; set; }
        public Feature[] features { get; set; }
    }

    public class Feature
    {
        public String type { get; set; }
        public PropertyInfo properties { get; set; }
    }

    public class PropertyInfo
    {
        public String headline { get; set; }
        public String description { get; set; }
        public DateTime effective { get; set; }
        public DateTime expires { get; set; }
    }
}
