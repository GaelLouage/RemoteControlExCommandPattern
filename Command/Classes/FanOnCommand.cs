using RemoteControlEx.Command.Interfaces;

namespace RemoteControlEx.Command.Classes
{
    public class FanOnCommand : ICommand 
    {
        public bool Execute()
        {
                return true;
        }
    }
}
