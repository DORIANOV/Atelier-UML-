using System.Collections.Generic;

namespace BanqueApp3
{
    public class Plateau : IAggregate
    {
        private List<Case> cases = new List<Case>();

        public void AjouterCase(Case c)
        {
            cases.Add(c);
        }

        public Case GetCase(int i)
        {
            return cases[i];
        }

        public int NbCases()
        {
            return cases.Count;
        }

        public IIterator CreateIterator()
        {
            return new PlateauIterator(this);
        }

        public List<Case> GetCases()
        {
            return cases;
        }
    }
}
