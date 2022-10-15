using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
    internal class Persoon
    {
        public string Name { get; set; }

        public Persoon(string name)
        {
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) { return false; }
            if(!(obj is Persoon)) { return false; }
            return (this.Name == (( Persoon)obj).Name);

        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
