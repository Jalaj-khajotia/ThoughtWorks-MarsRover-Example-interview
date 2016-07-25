using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Command
{
    public class RotateLeftCommand : ICommand
    {
        public void execute(MarsRover rover)
        {
            rover.turnLeft();
        }
    }
}
