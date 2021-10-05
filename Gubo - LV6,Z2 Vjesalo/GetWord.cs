using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubo___LV6_Z2_Vjesalo
{
    static class GetWord
    {
        public static string WordGetter()
        {
            string unsortedwords = "burek,dabar,glava,hlace,jakna,lista,mozak,novac,prsti,sunka,zlica,eskim,gusar,cetka,himna";

            List<string> sortedwords = unsortedwords.Split(',').ToList();
            int index = new Random().Next(sortedwords.Count);
            string secretword = sortedwords[index];
            return secretword;
        }
    }
}
