using System;
using System.Collections.Generic;

namespace BracketsApp
{
    public class Bracket
    {
        
        public List<BracketPlayer> Players { get; private set; }
        public List<BracketGame> Games { get; private set; }

        
        public int MaxGames { get; set; }

        public int MaxRounds { get; private set; }

        

        public Bracket(int max)
        {
            MaxGames = max;
            Players = new List<BracketPlayer>();
            Games = new List<BracketGame>();

            // the number of games should be a power of two. the +1
            // is to account for the fact that there are 2 players per game
            MaxRounds = (int) Math.Log(MaxGames,2) + 1;
        }


        public bool IsFull()
        {
            return Games.Count >= MaxGames;
        }

        

        public void AddGame(BracketGame game)
        {
            Games.Add(game);
            Players.Add(game.p1);
            Players.Add(game.p2);
            
        }

        
        public List<BracketGame> GetRound(int round)
        {
            
            if (round == 1)
            {
                return new List<BracketGame>(Games);
            }

            List<BracketGame> lastRound = GetRound(round - 1);
            List<BracketGame> thisRound = new List<BracketGame>();

            for (int i = 0; i < lastRound.Count; i+=2)
            {
                thisRound.Add(new BracketGame(lastRound[i].GetWinner(round-1), lastRound[i + 1].GetWinner(round-1)));
            }

            return thisRound;
        }



        public bool IsEligible(BracketGame bracket)
        {
            return !(Players.Contains(bracket.p1) || Players.Contains(bracket.p2));
        }

        
    }
}
