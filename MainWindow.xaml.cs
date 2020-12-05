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

namespace TicTacToe_WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Board gameBoard = new Board();
        }

        private void switchTurn()
        {
            if (currentPlayer.Text=="X")
            {
                currentPlayer.Text="O";
            }
            else
            {
                currentPlayer.Text = "X";
            }
        }

        private void gameCell9_Click(object sender, RoutedEventArgs e)
        {
            
            switchTurn();
        }

        private void gameCell8_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell7_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell6_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell5_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell4_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell3_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell2_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

        private void gameCell1_Click(object sender, RoutedEventArgs e)
        {
            switchTurn();
        }

    }
}
