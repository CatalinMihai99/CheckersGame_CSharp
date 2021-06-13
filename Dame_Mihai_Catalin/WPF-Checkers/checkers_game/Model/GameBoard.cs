using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace checkers_game.Model
{
    class GameBoard
    {
        public CheckerType[,] Board_array;

        public bool player_one_turn;

        public bool players_second_click;

        public List<Button> buttonList;

        public Button prevButton;

        public int row, column, prevRow, prevCol;

        public int p1_check_count, p2_check_count;

        public Brush p1_color;
        public Brush p2_color;
    }
}
