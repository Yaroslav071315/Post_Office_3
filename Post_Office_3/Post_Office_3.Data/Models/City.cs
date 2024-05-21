using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Office_3.Data
{
    public class City : ServiceObject
    {
        public string Name { get; set; }
        public List<PostOffice> PostOffices { get; set; } = new List<PostOffice>();
    }
}
