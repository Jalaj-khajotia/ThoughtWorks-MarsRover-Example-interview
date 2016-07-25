using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class CoOrdinates
    {
      public int xPosition;
      public int yPosition;
       public CoOrdinates(int x, int y)
       {
           xPosition = x;
           yPosition = y;
       }

       public string ToString()
       {
           return xPosition + " " + yPosition;
       }

     public bool isWithinBounds(CoOrdinates coOrdinate)
       {
          return xPosition >= coOrdinate.xPosition && yPosition >= coOrdinate.yPosition;
       }
    }
}
