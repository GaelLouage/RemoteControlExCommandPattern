using RemoteControlEx.Command.Classes;
using RemoteControlEx.Enums;
using RemoteControlEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RemoteControlEx.Extensions
{
    public static class RemoteControlExtensions
    {
        public static void ExecuteCommand(this RemoteControl control, Enums.CommandType commandType, string message)
        {
            var execute = control.Execute(commandType);
            if (execute is true)
            {
                MessageBox.Show($"{message} On");
            }
            else
            {
                MessageBox.Show($"{message} Off");
            }
        }

        public static Command.Interfaces.ICommand GetCommandType(this RemoteControlEx.Enums.CommandType commandType)
        {
            return commandType switch
            {

                CommandType.LIGHTON => new LightOnCommand(),
                CommandType.LIGHTOFF => new LightOffCommand(),
                CommandType.FANOFF => new FanOffCommand(),
                CommandType.FANON => new FanOnCommand(),
                _ => throw new NotSupportedException("No such command.")
            };
        }
    }
}
