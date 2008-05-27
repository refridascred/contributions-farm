using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long limit)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score - (score + 8)) ^ datum) - limit;
            }
            if (score > 53)
            {
                score = ((score << 3) ^ (score >> 2)) % 101;
            }
            return score;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((double)floor >= (5.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + floor))
                {
                    return 5;
                }
                else
                {
                    if (cur <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Active,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long limit)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if (1.42 >= (double)result)
                {
                    result = (result << 3) ^ (cell ^ limit);
                }
            }
            return result;
        }
    }
}
