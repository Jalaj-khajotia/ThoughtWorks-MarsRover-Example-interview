using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{   
   public class Direction
    {
      public enum dir { E, N, W, S }

      public dir currentDirection;
       public void turnLeft()
       {
           var position = (int) currentDirection;
           position = (position + 1) % 4;
           currentDirection = (dir)position;
       }
       public void turnRight()
       {
           var position = (int)currentDirection;
           position = (position - 1) % 4;
           if (position < 0)
           {
               position = 4 + position;
           }
           currentDirection = (dir)position;
       }
    }
}
