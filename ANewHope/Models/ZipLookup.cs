using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ANewHope.Models
{
    public class ZipLookup
    {
        public Place[] places { get; set; }
    }
    public class Place
    {
        public String city { get; set; }
        public String stateabbr { get; set; }
    }
}
