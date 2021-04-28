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

// build player classes simliar to the classes i made in python CompSci 1
// build locations next?
// add monsters to these locations
// once player defeats monster have gold and loot drop
// if usr losses to the monster
// reset location and refil their health to max or 75 not sure
// add side quests
// test
// usr info:
// name | idk
// class | Fighter
// HP | 10(int)
// XP | 0
// lvl | 1
// Gold | 25

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
    }
}
