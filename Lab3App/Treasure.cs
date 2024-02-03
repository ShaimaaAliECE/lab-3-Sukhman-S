using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score;
        public Treasure(String description, int score) : base(description)
        {
            Score = score;
        }
        public void UpdateTotalScore() 
        { 
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{base.Description} Collected, Congrats!!!!");
            UpdateTotalScore();
        }
    
    }
}
