using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentynine
{
    class SportsmanList
    {
        public List<Sportsman> SportsmenL { get; set; }

        public SportsmanList()
        {
            SportsmenL = new List<Sportsman>();
        }

        public SportsmanList(params Sportsman[] sportsmen)
        {
            SportsmenL = new List<Sportsman>(sportsmen);
        }


        public void Add(Sportsman sportsman)
        {
            if (!SportsmenL.Contains(sportsman)) SportsmenL.Add(sportsman);
            else Console.WriteLine("This sportsman already exists in the list.");
        }

        public void Remove(Sportsman sportsman)
        {
            if (SportsmenL.Contains(sportsman)) SportsmenL.Remove(sportsman);
            else Console.WriteLine("This sportsman does not exist in the list.");
        }

        public IEnumerable<Sportsman> GetAllSportsmenOf(string sportType)
        {
            foreach (Sportsman sportsman in SportsmenL)
            {
                if (sportsman.Sport == sportType)
                {
                    yield return sportsman;
                }
            }
        }
    }
}
