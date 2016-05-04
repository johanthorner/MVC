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
                    tiles.Add(new Cordinate { XCordinate = i, YCordinate = j, sign = 'o' });
                }
            }
            for (int j = 0; j <= 8; j++)
            {
                tiles[j].ID = j;
            }
            return horizontal;
        }

       

    }
   
}