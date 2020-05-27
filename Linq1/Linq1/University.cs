using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {

            Console.WriteLine("Uninversity {0} with Id  {1}", Name, Id);
        }
    }
}
