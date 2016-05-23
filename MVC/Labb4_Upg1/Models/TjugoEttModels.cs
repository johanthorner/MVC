using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb4_Upg1.Models
{
    public class TjugoEttModels
    {
        public static int CurrentNumber { get; set; }
        public static void SetStartPlayer()
        {
            if (RandomNumber() == 1)
                CurrentNumber = RandomNumber();
        }
        public static int RandomNumber()
        {
            Random randomNumber = new Random();
            return randomNumber.Next() % 2 == 0 ? 1 : 2;
        }

        public static int UppdateNumber { get; set; }

        public static void ComputorPlay()
        {
            if (CurrentNumber > 18)
            {
                CurrentNumber += 2;
            }
            else if (CurrentNumber > 10 && CurrentNumber % 2 == 0)
            {
                CurrentNumber += 2;
            }
            else if (CurrentNumber > 10)
            {
                CurrentNumber++;
            }
            else
            {
                CurrentNumber += RandomNumber();
            }

        }

        public static string HandleGameResults()
        {
            string playerResult = TjugoEttModels.IsGameOver("player");
            if (playerResult.Length > 0)
            {
                CurrentNumber = 0;
                return playerResult;
            }
            TjugoEttModels.ComputorPlay();
            string computorResult = TjugoEttModels.IsGameOver("computor");
            if (computorResult.Length > 0)
            {
                CurrentNumber = 0;
                return computorResult;
            }
            return  "Current number is: " + TjugoEttModels.CurrentNumber;

        }
        public static string IsGameOver(string turn)
        {
            if (CurrentNumber >= 21)
            {
                if (turn == "player")
                    return "You won! Congratulations";
                return "The Computor won. Better luck this thime.";
            }
            return string.Empty;
        }

    }
}