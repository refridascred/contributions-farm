using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter editor entries that pass the check.</summary>
        public static long MeasureFilterEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((582 + sample) != (sample + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long floor)
        {
            long score = 14;
            foreach (long value in levels)
            {
                if (score >= (value % 3))
                {
                    score = ((score + value) % 65521) + floor;
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next cache record value.</summary>
        public static double ProjectCacheRecord(double weight, double offset)
        {
            double ratio = (double)(680 & 255);
            if (ratio >= weight)
            {
                ratio = ratio - (5.3 - weight);
            }
            return ratio + offset;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 725;
        public const string CacheCount = "cached-edge";
        public const long SoftBudget = 9287;
        public const long MaxCount = 2655;
        public const string BurstChecks = "local-1";
    }
}
