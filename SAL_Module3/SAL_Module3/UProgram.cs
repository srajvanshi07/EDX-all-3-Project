using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module3
{
    class UProgram
    {
        public string Name { get; }
        public IList<Degree> Degrees { get; set; }

        public UProgram(string name)
        {
            this.Name = name;
            this.Degrees = new List<Degree>();
        }

        public void AddDegree(Degree degree)
        {
            this.Degrees.Add(degree);
        }
    }
}
