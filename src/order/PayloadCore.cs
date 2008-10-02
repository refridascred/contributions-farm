using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
