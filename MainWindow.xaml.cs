using System.Windows;

namespace TicTacToe_WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Board gameBoard = new Board();
        public MainWindow()
        {

            InitializeComponent();

        }

        private void switchTurn()
        {
            if (gameBoard.IsThereATie())
            {
                MessageBox.Show("Tie");
            }
            else if (gameBoard.IsThereAWinner())
            {
                if (currentPlayer.Text=="X")
                {
                    gameBoard.scoreX++;
                    scoreX.Text = gameBoard.scoreX.ToString();
                }
                else
                {
                    gameBoard.scoreO++;
                    scoreO.Text = gameBoard.scoreO.ToString();
                }
                MessageBox.Show("PLAYER \"" + currentPlayer.Text + "\" WON \n\n press \"NEW GAME\" to restart");
            }
            else
            {
                if (currentPlayer.Text == "X")
                {
                    currentPlayer.Text = "O";
                }
                else
                {
                    currentPlayer.Text = "X";
                }
            }                       
        }

        private void gameCell9_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(9, currentPlayer.Text[0]))
            {
                GameCell9.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell8_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(8, currentPlayer.Text[0]))
            {
                GameCell8.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell7_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(7, currentPlayer.Text[0]))
            {
                GameCell7.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell6_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(6, currentPlayer.Text[0]))
            {
                GameCell6.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell5_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(5, currentPlayer.Text[0]))
            {
                GameCell5.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell4_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(4, currentPlayer.Text[0]))
            {
                GameCell4.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell3_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(3, currentPlayer.Text[0]))
            {
                GameCell3.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell2_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(2, currentPlayer.Text[0]))
            {
                GameCell2.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void gameCell1_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(1, currentPlayer.Text[0]))
            {
                GameCell1.Content = currentPlayer.Text;
                switchTurn();
            }
        }

        private void GameResetClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            gameBoard.ResetBoard();
            GameCell1.Content = "";
            GameCell2.Content = "";
            GameCell3.Content = "";
            GameCell4.Content = "";
            GameCell5.Content = "";
            GameCell6.Content = "";
            GameCell7.Content = "";
            GameCell8.Content = "";
            GameCell9.Content = "";
            switchTurn();
        }
    }
}
