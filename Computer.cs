using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    public static class Computer
    {
        public static string? FindByFirstLetter(Towns towns, char first_letter)
        {
            var fName = towns.UnUsedNames.FirstOrDefault(t => t.ToLower().ElementAt(0) == char.ToLower(first_letter));
            return fName;
        }
    }
}
//Комментарий от Влдислава Гафиева
