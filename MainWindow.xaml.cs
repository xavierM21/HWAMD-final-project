using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using engine.ViewModels;


// https://docs.microsoft.com/en-us/dotnet/api/system.windows.routedeventargs?view=net-5.0

namespace HWAMDnew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;
        }
        // added for testing
        private void ButtonBase_onClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.XP = _gameSession.CurrentPlayer.XP + 10;
        }

        private void onClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void onClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void onClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void onClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }

        // moveEast,west,south,north will be added here and set as a private simliar to the event above
        // event handlers will be made inside gamesesson.cs
        // locationAt will be used to change location by suing Current.Location.Xcoord and Ycoord. images, descriptions and others should change if i did everything right.

    }
}
