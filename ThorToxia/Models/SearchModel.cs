using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThorToxia.Models
{
    public class SearchModel
    {
        public string Name { get; set; }
        public string Danger { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
