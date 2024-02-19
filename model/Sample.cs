using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardTemplate.model
{
    internal class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public Sample(int Id, string Name, string Description, int Age) { 
            this.Age = Age;
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }
    }
}
