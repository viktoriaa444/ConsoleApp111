using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GroupObject : DynamicObject
    {
        private readonly string name;
        private readonly string shortName;
        private readonly dynamic number;
        private readonly dynamic yearAdmission;


        public string Name { get { return name; } }
        public string ShortName { get { return shortName; } }
        public int Number { get { return number; } }
        public int YearAdmission { get { return yearAdmission; } }


        public GroupObject(string name, string shortName, int number, int yearAdmission)
        {
            this.name = name;
            this.shortName = shortName;
            this.number = number;
            this.yearAdmission = yearAdmission;

        }
    }
}

