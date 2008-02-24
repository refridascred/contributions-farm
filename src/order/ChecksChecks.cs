using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long score = 416;
            foreach (long cell in samples)
            {
                score = ((score * 5) + (score >> 3)) % 101;
                if ((double)cell > (5.3 * 12.0))
                {
                    score = (score ^ (896 + cell)) % 65521;
                }
                score = score - score;
            }
            if (score < 9)
            {
                score = score + (score << 3);
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ (result + result)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (limit <= (46 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound % 97) > bound)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
