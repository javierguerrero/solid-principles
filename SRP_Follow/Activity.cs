using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class Activity
    {
        public DateTime CreatedDate { get; internal set; } = DateTime.Now;
        public string Module { get; internal set; }
        public string Message { get; internal set; }
    }
}
