using MarsRover.Command;
using MarsRover.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class MarsRover
    {
       Direction currentDirection;
       Plateau roverPlateau;
       CoOrdinates currentCoOrdinate;

       public MarsRover(Direction direction, Plateau plateau, CoOrdinates position)
       {
           currentCoOrdinate = position;
           currentDirection = direction;
           roverPlateau = plateau;
       }

       public string currentLocation()
       {
           return currentCoOrdinate.ToString() + " "+ currentDirection.currentDirection;
       }

       public void run(string command)
       {
           List<ICommand> listCommands = new CommandParser(command).toCommands();
           foreach (var com in listCommands)
           {
               com.execute(this);
           }
       }

       public void turnRight()
       {
           currentDirection.turnRight();
       }
       public void turnLeft()
       {
           currentDirection.turnLeft();
       }
       public bool Move()
       {
           CoOrdinates coOrdinate = getCoOrdinateAfterMove();
           if (roverPlateau.isWithinBounds(coOrdinate))
           {
               currentCoOrdinate = coOrdinate;
               return true;
           }
           else
           {
              return false;
           }
       }

       CoOrdinates getCoOrdinateAfterMove()
       {
           CoOrdinates newCoOrdinate = new CoOrdinates(currentCoOrdinate.xPosition, currentCoOrdinate.yPosition);
           if (currentDirection.currentDirection == Direction.dir.E)
           {
               newCoOrdinate.xPosition++;
           }
           else if (currentDirection.currentDirection == Direction.dir.N)
           {
               newCoOrdinate.yPosition++;
           }
           else if (currentDirection.currentDirection == Direction.dir.W)
           {
               newCoOrdinate.xPosition--;
           }
           else
           {
               newCoOrdinate.yPosition--;
           }

           return newCoOrdinate;
       }
    }
}
