using System.Collections.Generic;

namespace SAL_Module1
{
    class UProgram
    {
        // variable declare
        private string programName;
        private List<Degree> degrees = new List<Degree>();

        //Properties declare
        public string ProgramName { get => programName; set => programName = value; }
        internal List<Degree> Degrees { get => degrees; set => degrees = value; }

        //constructor
        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }
        public UProgram(string programName, List<Degree> degrees)
        {
            this.ProgramName = programName;
            this.Degrees = degrees;
        }
        public void AddDegree(Degree degree)
        {
            Degrees.Add(degree);
        }

    }
}
