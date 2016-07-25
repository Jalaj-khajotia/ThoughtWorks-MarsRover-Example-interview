using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Command
{
   public interface ICommand
    {
       void execute(MarsRover rover);
    }
}
