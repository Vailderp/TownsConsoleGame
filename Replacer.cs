using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    public static class Replacer
    {
        public static void Replace(Towns towns, string name)
        {
            var fName = towns.UnUsedNames.FirstOrDefault(t => string.Equals(t, name, StringComparison.OrdinalIgnoreCase));
            if (fName == null) return;
            towns.UnUsedNames.Remove(fName);
            towns.AlreadyUsedNames.Add(fName);
        }
    }
}
