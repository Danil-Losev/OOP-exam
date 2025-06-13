using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentynine
{
    public class Sportsman
    {
        private string name;
        private int age;
        private string sport;
        private int yearsInSport;


        public Sportsman()
        {
            name = "Unknown";
            age = 0;
            sport = "Unknown";
            yearsInSport = 0;
        }

        public Sportsman(string inName, int inAge, string inSport, int inYearsInSport)
        {
            name = inName;
            age = inAge;
            sport = inSport;
            yearsInSport = inYearsInSport;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }
        public int YearsInSport
        {
            get { return yearsInSport; }
            set { yearsInSport = value; }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Sportsman other)
            {
                return name == other.name && age == other.age && sport == other.sport && yearsInSport == other.yearsInSport;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + age.GetHashCode() + sport.GetHashCode() + yearsInSport.GetHashCode();
        }

        public override string ToString()
        {
            return "Name: " + name + ", Age: " + age + ", Sport: " + sport + ", Years in Sport: " + yearsInSport;
        }
    }
}
