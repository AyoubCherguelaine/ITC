using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itc
{
    static public class Membre_add
    {

        
        static public ArrayList Membre_adding;
        static private int Number=0;
        static public void add(Membre.Membre x)
        {
            Membre_adding.Add(x);
            Number++;
        }
        static public void remove()
        {
            Membre_adding.RemoveAt(Number);
        }

    }
}