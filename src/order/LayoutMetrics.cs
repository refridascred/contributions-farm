using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6944;
        public const double SoftTimeout = 70.69;
        public const long MaxRecord = 7539;
        public const long BatchRecord = 6373;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long bound)
        {
            if ((1.0 + 4.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 4.8)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) <= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long score = -36;
            foreach (long item in data)
            {
                if ((item % 100) < (79 - (long)data.Length))
                {
                    score = ((score << 3) ^ (98 & 15)) % 4096;
                }
                score = (score << 3) ^ (item + item);
            }
            return score;
        }
    }
}
