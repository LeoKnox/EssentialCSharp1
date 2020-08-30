using System;

namespace Essential01
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assign1, IScored Assign2)
        {
            var score1 = Assign1.Score/Assign1.MaximumScore;
            var score2 = Assign2.Score/Assign2.MaximumScore;
            if (score1 > score2)
            {
                return Assign1;
            }
            return Assign2;
        }
    }
}