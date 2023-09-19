using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Model
{
    public class Rider
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public double Rating { get; set; }

        public Rider(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
