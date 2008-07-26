using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "standard-v2";
        public const string RetryAlready = "standard-1";
        public const string IdleAlready = "cached";
        public const long WindowAlready = 4932;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 76;
            foreach (long entry in levels)
            {
                score = (((score * 2) + 5) % 101) ^ entry;
                if ((score + 28) < (5 + 961))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score % 12)) % 97;
            }
            return score;
        }
    }
}
