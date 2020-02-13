using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module3
{
    class Teacher : Person
    {

        public bool IsAssistant { get; }

        public Teacher(string fileName, bool isAssistant) : base(fileName)
        {
            this.IsAssistant = isAssistant;
        }

    }
}
