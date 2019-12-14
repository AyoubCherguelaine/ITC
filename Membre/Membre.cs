using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itc.Membre
{
   public class Membre : MAn
    {

        public Function Function;
       
        public string Team;
    
        // constractor
        public Membre(string name, string surname , string team = "" )
        {
            this.name = name;
            this.surname = surname;
            this.Team = team;
          //  Function = function;
            this.Order = new List<Order_>();

        }



        public void addFunction(Function x)
        {
            this.Function = x;
        }
        public void addOrder(Order_ m)
        {
            Order.Add(m);
            
            
          
        }
        public void addTeam(string team)
        {
            this.Team = team;
        }
        public IList<Order_> Order;


    }
}
