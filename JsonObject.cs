using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializerApp
{
    public class JsonTask
    {
        public JsonObject tasks { get; set; }
    }

    public class JsonObject
    {
        public string topic { get; set; }
        public string title { get; set; }
    }
}
