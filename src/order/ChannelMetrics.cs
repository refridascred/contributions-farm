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

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long CountChecksCommitsGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry >= (count - floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
