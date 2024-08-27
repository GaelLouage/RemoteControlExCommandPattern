using RemoteControlEx.Command.Classes;
using System.Windows.Input;
using RemoteControlEx.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlEx.Enums;
using RemoteControlEx.Extensions;


namespace RemoteControlEx.Models
{
    public class RemoteControl 
    {
        public Command.Interfaces.ICommand Command {get;set;} 
        public bool Execute(RemoteControlEx.Enums.CommandType command)
        {
            Command = command.GetCommandType();
            return Command.Execute();
        }
    }
}
