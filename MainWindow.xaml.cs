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
            if (gameBoard.IsThereAWinner())
            {
                if (currentPlayer.Text == "X")
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
            else if (gameBoard.IsThereATie())
            {
                MessageBox.Show("Tie");
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

        private void CellClick(object sender, RoutedEventArgs e)
        {
            if (gameBoard.MarkCell(int.Parse(((sender as System.Windows.Controls.Button).Name)[8].ToString()), currentPlayer.Text[0]))
            {
                (sender as System.Windows.Controls.Button).Content = currentPlayer.Text;
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
