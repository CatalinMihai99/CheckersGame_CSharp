using checkers_game.Model;
using checkers_game.View;
using checkers_game.ViewModel;
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
using System.Windows.Threading;

namespace checkers_game
{
    public partial class MainWindow : Window
    {
        GameBoard boardgame = new GameBoard();
        FunctionsVM functii = new FunctionsVM();


        public MainWindow()
        {
            InitializeComponent();
            boardgame.p1_color = new SolidColorBrush(Color.FromRgb(127, 255, 0));
            boardgame.p2_color = new SolidColorBrush(Color.FromRgb(0, 0, 255));

            NewGame();


        }

        private void NewGame()
        {
            boardgame.buttonList = Board.Children.Cast<Button>().ToList();

            boardgame.Board_array = new CheckerType[8, 8];

            for (int row = 0; row < 8; row++)
            {
                if (row == 0 || row == 2 || row == 6)
                {

                    for (int col = 0; col < 7; col += 2)
                    {

                        if (row == 0 || row == 2) { boardgame.Board_array[row, col] = CheckerType.P2_check; }

                        else { boardgame.Board_array[row, col] = CheckerType.P1_check; }

                    }

                }

                if (row == 1 || row == 5 || row == 7) {

                    for (int col = 1; col < 8; col += 2)
                    {

                        if (row == 5 || row == 7) { boardgame.Board_array[row, col] = CheckerType.P1_check; }

                        else { boardgame.Board_array[row, col] = CheckerType.P2_check; }

                    }

                }
            }

            boardgame.player_one_turn = true;
            boardgame.players_second_click = false;
            boardgame.row = -1;
            boardgame.column = 0;
            boardgame.prevRow = 0;
            boardgame.prevCol = 0;


            boardgame.p1_check_count = 12;
            boardgame.p2_check_count = 12;


            int counter = 0;

            boardgame.buttonList.ForEach(button =>

            { if (counter < 12)
                {
                    button.Content = "💚";
                    button.Foreground = boardgame.p2_color;
                    counter++;
                }
                else if (counter >= 20 && counter < 32)
                {
                    button.Content = "💚";
                    button.Foreground = boardgame.p1_color;
                    counter++;
                }
                else {
                    button.Content = string.Empty;
                    counter++; }
            }
            );

            functii.boardgame = boardgame;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            functii.ButtonClick(sender, e);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Instructions x = new Instructions();
            x.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            data.Text = DateTime.Now.ToString();

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Statistici x = new Statistici();
            x.Show();
            Close();

        }
        

    }
}
