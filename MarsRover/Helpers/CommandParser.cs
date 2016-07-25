using MarsRover.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Helpers
{
    public class CommandParser
    {
        private string commandString;
        static Dictionary<string, ICommand> stringToCommand = new Dictionary<string, ICommand>
        { { "M", new MoveCommand() }, { "R", new RotateRightCommand() }, { "L", new RotateLeftCommand() } };
        public CommandParser(string command)
        {
            commandString = command;
        }
        public List<ICommand> toCommands()
        {
            return buildCommandList(commandString);
        }

        List<ICommand> buildCommandList(string command){
            List<ICommand> commandList = new List<ICommand>();
            
            foreach (var character in command)
            {
                ICommand commandValue;
                stringToCommand.TryGetValue(character.ToString(),out commandValue);
                commandList.Add(commandValue);                
            }
            return commandList;
        }
        
    }
}
