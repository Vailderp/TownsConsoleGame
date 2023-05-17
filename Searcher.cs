using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    public static class Searcher
    {
        private static char[] _invalidLetters = new char[3]
        {
            'ы', 'ь', 'ъ'
        };
        public static string? Search(Towns towns, string name)
        {
            var fName = towns.UnUsedNames.FirstOrDefault(t => string.Equals(t, name, StringComparison.OrdinalIgnoreCase));
            if (fName == null) return null;
            Replacer.Replace(towns, fName);
            return fName;
        }
        public static char SearchLastPermissibleLetter(string name)
        {
            return name.Last(l => !_invalidLetters.Contains(l));
        }
    }
}
