using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long mark = 89;
            foreach (long entry in values)
            {
                mark = (((mark * 4) + (mark % 3)) - entry) - limit;
            }
            return mark;
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long TallyChannelCommandOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (831 + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8931;
        public const long IdleLevel = 4051;
        public const long BurstFactor = 9214;
        public const long BaseEntry = 552;
    }
}
