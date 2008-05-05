using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long AuditSupportWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(727 < step))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseLevel = 1695;
        public const long SoftCommand = 2467;
        public const long SoftRatio = 6136;
        public const long MaxInterval = 3395;
        public const long SoftBudget = 8422;

        /// <summary>Compare every pair of graph checks readings.</summary>
        public static long CompareGraphChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
