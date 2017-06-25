using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonString
{
    public class Algo
    {
        public string Run(params string[] allStrings)
        {
            var smallest = FindSmallest(allStrings);
            var result = string.Empty;
            for (int i = smallest.Length; i > 0; i--)
            {
                foreach (var part in GetAllPossibleParts(smallest, i))
                {
                    if(allStrings.All(c=>c.IndexOf(part) > -1))
                    {
                        result = part;
                        break;                        
                    }
                }

                if(!string.IsNullOrEmpty(result))
                {
                    break;
                }
            }

            return result;
        }

        private List<string> GetAllPossibleParts(string smallString, int size)
        {
            var list = new List<string>();
            for (int i = 0; i <= smallString.Length-size; i++)
            {
                list.Add(smallString.Substring(i, size));
            }
            return list;
        }

        private string FindSmallest(string[] allStrings)
        {
            return allStrings.OrderBy(c => c.Length).First();
        }
    }
}
