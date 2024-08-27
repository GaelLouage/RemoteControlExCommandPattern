using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlEx.Command.Interfaces
{
    public interface ICommand
    {
        public bool Execute();
    }
}
