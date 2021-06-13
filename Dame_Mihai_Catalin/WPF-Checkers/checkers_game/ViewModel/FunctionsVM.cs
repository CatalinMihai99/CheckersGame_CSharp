using checkers_game.Model;
using checkers_game.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace checkers_game.ViewModel
{
    class FunctionsVM
    {
        public GameBoard boardgame = new GameBoard();
        private bool game_over()
        {
            if (boardgame.p1_check_count == 0 || boardgame.p2_check_count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool p1_jump_available()
        {
            if (boardgame.row - 2 >= 0 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row - 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_king))
            {
                return true;

            }
            else if (boardgame.row - 2 >= 0 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row - 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_king))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        private void borderChangeOnCLick(Button button)
        {
            button.BorderThickness = new Thickness(3, 3, 3, 3);
            button.BorderBrush = Brushes.Snow;
        }

        private void borderChangeBack(Button button)
        {
            button.BorderThickness = new Thickness(1, 1, 1, 1);
            button.BorderBrush = Brushes.SlateGray;
        }
        private void updateBoardGui()
        {

            boardgame.buttonList.ForEach(button => {

                int row = Grid.GetRow(button);
                int col = Grid.GetColumn(button);

                if (boardgame.Board_array[row, col] == CheckerType.P1_check)
                {
                    button.Content = "💚";
                    button.Foreground = boardgame.p1_color;
                }
                else if (boardgame.Board_array[row, col] == CheckerType.P1_king)
                {
                    button.Content = "♛";
                    button.Foreground = boardgame.p1_color;
                }
                else if (boardgame.Board_array[row, col] == CheckerType.P2_check)
                {
                    button.Content = "💚";
                    button.Foreground = boardgame.p2_color;
                }
                else if (boardgame.Board_array[row, col] == CheckerType.P2_king)
                {
                    button.Content = "♚";
                    button.Foreground = boardgame.p2_color;
                }
                else
                {
                    button.Content = "";
                }


            });
        }
        private bool is_normal_king_move()
        {
            if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == 1 || boardgame.row - boardgame.prevRow == -1) && (boardgame.column - boardgame.prevCol == 1 || boardgame.column - boardgame.prevCol == -1))
            {

                boardgame.Board_array[boardgame.row, boardgame.column] = boardgame.Board_array[boardgame.prevRow, boardgame.prevCol];
                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool is_valid_king_jump()
        {
            if (boardgame.player_one_turn)
            {
                if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == 2 && boardgame.column - boardgame.prevCol == 2)
                {
                    if (boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == 2 && boardgame.column - boardgame.prevCol == -2)
                {
                    if (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == -2 && boardgame.column - boardgame.prevCol == 2)
                {
                    if (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == -2 && boardgame.column - boardgame.prevCol == -2)
                {
                    if (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == 2 && boardgame.column - boardgame.prevCol == 2)
                {
                    if (boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == 2 && boardgame.column - boardgame.prevCol == -2)
                {
                    if (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == -2 && boardgame.column - boardgame.prevCol == 2)
                {
                    if (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && boardgame.row - boardgame.prevRow == -2 && boardgame.column - boardgame.prevCol == -2)
                {
                    if (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

        }
        private void End_turn()
        {
            Is_kinged();
           
            boardgame.players_second_click = !boardgame.players_second_click;
            boardgame.player_one_turn = !boardgame.player_one_turn;
            
        }
        private bool more_king_jump_available()
        {
            if (boardgame.player_one_turn)
            {
                if (boardgame.row - 2 >= 0 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row - 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P2_king))
                {
                    return true;

                }
                else if (boardgame.row - 2 >= 0 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row - 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P2_king))
                {

                    return true;
                }
                else if (boardgame.row + 2 <= 7 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row + 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_king))
                {
                    return true;

                }
                else if (boardgame.row + 2 <= 7 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row + 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_king))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (boardgame.row - 2 >= 0 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row - 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] == CheckerType.P1_king))
                {
                    return true;

                }
                else if (boardgame.row - 2 >= 0 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row - 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_king))
                {

                    return true;
                }
                else if (boardgame.row - 2 >= 0 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row + 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_king))
                {
                    return true;

                }
                else if (boardgame.row - 2 >= 0 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row + 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_king))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


        private bool Is_kinged()
        {
            System.Console.WriteLine("is kinged row " + boardgame.row);

            if (boardgame.row == 0 && boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] == CheckerType.P1_check)
            {
                System.Console.WriteLine("should be kinged");
                boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P1_king;
                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                updateBoardGui();
                return true;

            }
            else if (boardgame.row == 7 && boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] == CheckerType.P2_check)
            {
                boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P2_king;
                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                updateBoardGui();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void invalid_choice()
        {
            boardgame.players_second_click = false;
            borderChangeBack(boardgame.prevButton);

        }

        private bool p2_jump_available()
        {

            if (boardgame.row + 2 <= 7 && boardgame.column + 2 <= 7 && boardgame.Board_array[boardgame.row + 2, boardgame.column + 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P1_king))
            {
                return true;
            }
            else if (boardgame.row + 2 <= 7 && boardgame.column - 2 >= 0 && boardgame.Board_array[boardgame.row + 2, boardgame.column - 2] == CheckerType.Free && (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P1_king))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public void ButtonClick(object sender, RoutedEventArgs e)
        {

            if (game_over())
            {
                
                    int x, y;
                    using (TextReader reader = File.OpenText("C:\\Users\\Cata\\Desktop\\sah\\WPF-Checkers\\checkers_game\\Resources\\Statitics.txt"))
                    {
                        x = int.Parse(reader.ReadLine());
                        y = int.Parse(reader.ReadLine());


                    }
                    if (boardgame.p1_check_count > 0)
                    {
                        x++;
                        _ = MessageBox.Show("VERDELE A CASTIGAT!", "JOCUL S-A TERMINAT!");
                    }
                    else
                    {
                        y++;
                        _ = MessageBox.Show("ALBASTRU A CASTIGAT!", "JOCUL S-A TERMINAT!");
                    }

                    File.Create("C:\\Users\\Cata\\Desktop\\sah\\WPF-Checkers\\checkers_game\\Resources\\Statitics.txt").Close();


                    File.AppendAllText("C:\\Users\\Cata\\Desktop\\sah\\WPF-Checkers\\checkers_game\\Resources\\Statitics.txt", x + Environment.NewLine);
                    File.AppendAllText("C:\\Users\\Cata\\Desktop\\sah\\WPF-Checkers\\checkers_game\\Resources\\Statitics.txt", y + Environment.NewLine);


                
;                                                                           
            }





            var button = (Button)sender;

            boardgame.column = Grid.GetColumn(button);
            boardgame.row = Grid.GetRow(button);

            if (boardgame.player_one_turn)
            {
                if (boardgame.players_second_click)
                {

                    boardgame.prevRow = Grid.GetRow(boardgame.prevButton);
                    boardgame.prevCol = Grid.GetColumn(boardgame.prevButton);
                    if (boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] == CheckerType.P1_check)
                    {
                        if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == -1) && (boardgame.column - boardgame.prevCol == -1 || boardgame.column - boardgame.prevCol == 1))
                        {

                            if (!Is_kinged())
                            {
                                boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P1_check;
                                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;
                                button.Content = "💚";
                                button.Foreground = boardgame.p1_color;
                                borderChangeBack(boardgame.prevButton);
                                boardgame.prevButton.Content = "";

                            }

                            End_turn();
                            borderChangeBack(boardgame.prevButton);

                        }
                        else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == -2) && (boardgame.column - boardgame.prevCol == -2))
                        {
                            if (boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] == CheckerType.P2_king)
                            {
                                boardgame.p2_check_count--; 

                                boardgame.Board_array[boardgame.row + 1, boardgame.column + 1] = CheckerType.Free;


                                if (Is_kinged())
                                {
                                    End_turn();
                                    borderChangeBack(boardgame.prevButton);
                                }
                                else
                                {
                                    boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P1_check;
                                    boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                                    borderChangeBack(boardgame.prevButton);
                                    updateBoardGui();


                                    if (p1_jump_available())
                                    {
                                        boardgame.prevButton = button;
                                        borderChangeOnCLick(button);

                                    }
                                    else
                                    {
                                        End_turn();
                                        borderChangeBack(boardgame.prevButton);
                                    }
                                }

                            }
                        }
                        else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == -2) && (boardgame.column - boardgame.prevCol == 2))
                        {

                            if (boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_check || boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] == CheckerType.P2_king)
                            {
                                boardgame.p2_check_count--; 

                                boardgame.Board_array[boardgame.row + 1, boardgame.column - 1] = CheckerType.Free;

                                if (Is_kinged())
                                {
                                    End_turn();
                                    borderChangeBack(boardgame.prevButton);
                                }
                                else
                                { 
                                    boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P1_check;
                                    boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                                    borderChangeBack(boardgame.prevButton);
                                    updateBoardGui();

                                    if (p1_jump_available())
                                    {
                                        boardgame.prevButton = button;
                                        borderChangeOnCLick(button);

                                    }
                                    else
                                    {
                                        End_turn();
                                        borderChangeBack(boardgame.prevButton);
                                    }
                                }


                            }

                        }
                        else
                        {
                            invalid_choice();
                        }
                    }
                    else
                    {
                        if (is_normal_king_move())
                        {
                            button.Content = "♛";
                            button.Foreground = boardgame.p1_color;

                            boardgame.prevButton.Content = "";

                            borderChangeBack(boardgame.prevButton);

                            End_turn();

                        }
                        else if (is_valid_king_jump())
                        {
                            boardgame.p2_check_count--;
                            int jumped_row = (int)(boardgame.row + ((boardgame.row - boardgame.prevRow) * -.5));
                            int jumped_col = (int)(boardgame.column + ((boardgame.column - boardgame.prevCol) * -.5));


                            boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P1_king;

                            System.Console.WriteLine("value of jumped piece " + (jumped_row) + "  " + (jumped_col));
                            boardgame.Board_array[jumped_row, jumped_col] = CheckerType.Free;

                            boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                            borderChangeBack(boardgame.prevButton);
                            updateBoardGui();

                            if (more_king_jump_available())
                            {
                                boardgame.prevButton = button;
                                borderChangeOnCLick(button);

                            }
                            else
                            {

                                End_turn();
                                borderChangeBack(boardgame.prevButton);
                            }
                        }
                        else
                        {
                            invalid_choice();
                        }

                    }



                }

                else
                {
                    if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.P1_check || boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.P1_king)
                    {
                        boardgame.prevButton = button; 
                        borderChangeOnCLick(button);
                        boardgame.players_second_click = true;
                    }


                }
            }
            else
            {
                if (boardgame.players_second_click)
                {
                    boardgame.prevRow = Grid.GetRow(boardgame.prevButton);
                    boardgame.prevCol = Grid.GetColumn(boardgame.prevButton);
                    if (boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] == CheckerType.P2_check)
                    {
                        if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == 1) && (boardgame.column - boardgame.prevCol == -1 || boardgame.column - boardgame.prevCol == 1))
                        {
                            if (!Is_kinged())
                            {
                                boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P2_check;

                                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                                button.Content = "💚";
                                button.Foreground = boardgame.p2_color;
                                borderChangeBack(boardgame.prevButton);
                                boardgame.prevButton.Content = "";
                            }

                            End_turn();
                            borderChangeBack(boardgame.prevButton);
                        }
                        else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == 2) && boardgame.column - boardgame.prevCol == -2)
                        {
                            if (boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_check || boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] == CheckerType.P1_king)
                            {
                                boardgame.p1_check_count--;

                                boardgame.Board_array[boardgame.row - 1, boardgame.column + 1] = CheckerType.Free;


                                if (Is_kinged())
                                {
                                    End_turn();
                                    borderChangeBack(boardgame.prevButton);
                                }
                                else
                                {

                                    boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P2_check;
                                    boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;


                                    borderChangeBack(boardgame.prevButton);
                                    updateBoardGui();

                                    if (p2_jump_available())
                                    {
                                        borderChangeOnCLick(button);
                                        boardgame.prevButton = button;
                                    }
                                    else
                                    {
                                        End_turn();
                                        borderChangeBack(boardgame.prevButton);
                                    }
                                }
                            }
                        }
                        else if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.Free && (boardgame.row - boardgame.prevRow == 2) && boardgame.column - boardgame.prevCol == 2)
                        {

                            boardgame.p1_check_count--;

                            boardgame.Board_array[boardgame.row - 1, boardgame.column - 1] = CheckerType.Free;


                            if (Is_kinged())
                            {
                                End_turn();
                                borderChangeBack(boardgame.prevButton);
                            }
                            else
                            {


                                boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P2_check;
                                boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                                borderChangeBack(boardgame.prevButton);
                                updateBoardGui();

                                if (p2_jump_available())
                                {
                                    borderChangeOnCLick(button);
                                    boardgame.prevButton = button;
                                }
                                else
                                {
                                    End_turn();
                                    borderChangeBack(boardgame.prevButton);
                                }
                            }

                        }
                        else
                        {
                            invalid_choice();
                        }
                    }
                    else
                    {
                        if (is_normal_king_move())
                        {
                            button.Content = "♚";
                            button.Foreground = boardgame.p2_color;

                            boardgame.prevButton.Content = "";

                            borderChangeBack(boardgame.prevButton);

                            End_turn();

                        }
                        else if (is_valid_king_jump())
                        {
                            boardgame.p1_check_count--;
                            int jumped_row = (int)(boardgame.row + ((boardgame.row - boardgame.prevRow) * -.5));
                            int jumped_col = (int)(boardgame.column + ((boardgame.column - boardgame.prevCol) * -.5));


                            boardgame.Board_array[boardgame.row, boardgame.column] = CheckerType.P2_king;

                            System.Console.WriteLine("value of jumped piece " + (boardgame.row + jumped_row) + "  " + (boardgame.column + jumped_col));
                            boardgame.Board_array[jumped_row, jumped_col] = CheckerType.Free;

                            boardgame.Board_array[boardgame.prevRow, boardgame.prevCol] = CheckerType.Free;

                            borderChangeBack(boardgame.prevButton);
                            updateBoardGui();


                            if (more_king_jump_available())
                            {
                                boardgame.prevButton = button;
                                borderChangeOnCLick(button);

                            }
                            else
                            {
                                End_turn();
                                borderChangeBack(boardgame.prevButton);
                            }
                        }
                        else
                        {
                            invalid_choice();
                        }
                    }
                }
                else
                {
                  //  current_player.Text = "Player 2 Turn";                                                     //

                    if (boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.P2_check || boardgame.Board_array[boardgame.row, boardgame.column] == CheckerType.P2_king)
                    {
                        boardgame.prevButton = button;
                        boardgame.players_second_click = true;
                        borderChangeOnCLick(button);
                    }
                }


            }




        }
    }
}
