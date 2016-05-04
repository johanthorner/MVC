using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb2_upg2.Models
{
    public class GameModel
    {
        public static int InitializeBoard(List<Cordinate> tiles)
        {
            int horizontal = 8;
            int vertical = 3;
            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    tiles.Add(new Cordinate { XCordinate = i, YCordinate = j, sign = ' ' });
                }
            }
            for (int j = 0; j <= 8; j++)
            {
                tiles[j].ID = j;
            }
            return horizontal;
        }

        public static string CheckForWinner(char checkForWin)
        {
            if (CheckForDiagonalWin(checkForWin) || CheckForVerticalWin(checkForWin) || CheckForHorizontalWin(checkForWin))
            {
                if (checkForWin == 'X')
                    return "You are the winner!";

                if (checkForWin == 'O')
                    return "You lost, the computer won...";
            }
            return string.Empty;
        }
        public static bool CheckForDiagonalWin(char checkForSign)
        {
            if (Tiles.TileCordinates[0].sign == checkForSign && Tiles.TileCordinates[4].sign == checkForSign && Tiles.TileCordinates[8].sign == checkForSign)
            {
                return true;
            }
            if (Tiles.TileCordinates[2].sign == checkForSign && Tiles.TileCordinates[4].sign == checkForSign && Tiles.TileCordinates[6].sign == checkForSign)
            {
                return true;
            }
            return false;

        }

        public static bool CheckForVerticalWin(char checkForSign)
        {
            for (int i = 0; i < 3; i ++)
            {
                if (Tiles.TileCordinates[i].sign == checkForSign && Tiles.TileCordinates[i + 3].sign == checkForSign && Tiles.TileCordinates[i + 6].sign == checkForSign)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckForHorizontalWin(char checkForSign)
        {
            for (int i = 0; i < 9; i+=3)
            {
                if (Tiles.TileCordinates[i].sign == checkForSign && Tiles.TileCordinates[i + 1].sign == checkForSign && Tiles.TileCordinates[i + 2].sign == checkForSign)
                {
                    return true;
                }
            }
            return false;
        }

        public static int ComputerPlay()
        {
            return 1;


        }

    }

}