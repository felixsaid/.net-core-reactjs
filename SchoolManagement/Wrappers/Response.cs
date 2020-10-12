using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Wrappers
{
    public class Response
    {
        public bool error { get; set; }
        public object data { get; set; }
        public string message { get; set; }


    }
}
