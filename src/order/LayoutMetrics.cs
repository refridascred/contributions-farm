using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (state / 6)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long step)
        {
            long score = 346;
            foreach (long item in items)
            {
                score = ((score << 2) ^ step) % 255;
                score = ((score * 5) + (item + 1)) % 65521;
            }
            if (score > 16)
            {
                score = (score ^ (score / 7)) % 65521;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
