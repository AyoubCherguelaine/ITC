using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itc
{
    public class Classer
    {

        public bool more(string x,string y)
        {
            bool ok = true, k = false;
            int  i = 0;
            while (!k)
            {
                if(x[i] > y[i])
                {
                    k = true;
                    ok = true;
                }
                else
                {
                    if(x[i] == y[i])
                    {
                        i++;
                    }
                    else
                    {
                        k = true;
                        ok = false;
                    }
                }
            }
            

            return ok;
        }

        public void PermutString(string [] list)
        {
        
            string ch;
            int i = 0; int j = 0;
            bool bo = true;

            while ( ( i< list.Length - 1) && (bo))
            {
                bo = false;
                j = i + 1;
                while(j< list.Length)
                {
                    if ( ! more(list[i], list[j]))
                    {
                        bo = true;
                        ch = list[i];
                        list[i] = list[j];
                        list[j] = ch;
                    }
                    j++;
                }
                i++;
            }
        }


    }
}