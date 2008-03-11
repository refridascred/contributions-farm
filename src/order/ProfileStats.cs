using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long score = 7;
            foreach (long value in values)
            {
                if (7.1 > (double)score)
                {
                    break;
                }
                if ((5.24 * 17.0) <= (5.0 + 5.3))
                {
                    score = (score - (126 % 7)) % 255;
                }
                if (((5.7 * 5.08) <= (double)score) && ((score + value) < (value % 8)))
                {
                    score = score ^ (value << 2);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if ((53 >= (value - value)) || ((long)levels.Length <= (value & 255)))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (3 >> 2)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const string RetryScore = "standard-1";
        public const string BaseWidth = "cached";
        public const string StepCount = "open-1";
    }
}
