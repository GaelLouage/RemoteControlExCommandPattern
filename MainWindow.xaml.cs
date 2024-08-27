using RemoteControlEx.Command.Classes;
using RemoteControlEx.Enums;
using RemoteControlEx.Extensions;
using RemoteControlEx.Models;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemoteControlEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RemoteControl _remoteControl = new RemoteControl();
    

        public MainWindow() 
        {

            _remoteControl = new RemoteControl();
        }

        private void btnLightOn_Click(object sender, RoutedEventArgs e)
        {
           
            _remoteControl.ExecuteCommand(Enums.CommandType.LIGHTON, "Light");
        }



        private void btnLightOff_Click(object sender, RoutedEventArgs e)
        {
            _remoteControl.ExecuteCommand(Enums.CommandType.LIGHTOFF, "Light");
        }
      

        private void btnFanOn_Click(object sender, RoutedEventArgs e)
        {
            _remoteControl.ExecuteCommand(Enums.CommandType.FANON, "Fan");
        }

        private void btnFanOff_Click(object sender, RoutedEventArgs e)
        {
            _remoteControl.ExecuteCommand(Enums.CommandType.FANOFF, "Fan");
        }
    }
}