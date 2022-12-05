using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brezerkers_Assignemnt
{
    internal class Bag : IRandomProvider
    {
        List<int> _oddSeriesList = new(); 
        List<int> _evenSeriesList = new();

        private bool _isListOdd = true;

        public Bag()
        {
            int x = Random.Shared.Next(5, 13);
            for (int i = 0; i < x; i++)
            {
                _oddSeriesList.Add(Random.Shared.Next(2, 21));
            }
        }

        public int RandomNumber()
        {
            
            if (_oddSeriesList.Count == 0)
            {
                _isListOdd = false;
            }
            if (_evenSeriesList.Count == 0)
            {
                _isListOdd = true;
            }
            if (_isListOdd == true)
            {
                int listIndexer = Random.Shared.Next(0,_oddSeriesList.Count);
                int listValue = _oddSeriesList[listIndexer];
                _evenSeriesList.Add(listValue);
                _oddSeriesList.Remove(listValue);
                return listValue;
            }
            else
            {
                int listIndexer = Random.Shared.Next(0, _evenSeriesList.Count);
                int listValue = _evenSeriesList[listIndexer];
                _oddSeriesList.Add(listValue);
                _evenSeriesList.Remove(listValue);
                return listValue;
            }
        }
    }
}
