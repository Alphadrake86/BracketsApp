using System;
using System.Collections.Generic;

namespace BracketsApp
{
    public class BracketPlayer
    {
        public string name;
        public int[] games;

        public BracketPlayer(string name, int[] games)
        {
            this.name = name;
            this.games = games;
        }

        public override bool Equals(object obj)
        { 
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BracketPlayer p = (BracketPlayer)obj;
                return (name == p.name) && (games == p.games);
            }
        }

        public override int GetHashCode()
        {
            int hashCode = -471272590;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(games);
            return hashCode;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
