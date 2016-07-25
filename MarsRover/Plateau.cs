using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class Plateau
    {
       public Plateau(int x, int y)
       {
           this.bottomLeftCoOrdinate = new CoOrdinates(0, 0);
           this.upperRightCoOrdinate = new CoOrdinates(x,y);
       }
       CoOrdinates bottomLeftCoOrdinate;
       CoOrdinates upperRightCoOrdinate;

      public bool isWithinBounds(CoOrdinates coOrdinate)
       {
           return !bottomLeftCoOrdinate.isWithinBounds(coOrdinate) && 
               upperRightCoOrdinate.isWithinBounds(coOrdinate);
       }
    }
}
