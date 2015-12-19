using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    class GreenhouseEvent
    {
        public string Action { get; set; }
        public Payload Payload { get; set; }
    }

    class Payload
    {
        public int Web_hook_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
        public bool Active { get; set; }
    }
}
