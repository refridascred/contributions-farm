using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5160;
        public const long LimitBudget = 1471;
        public const long MinBatch = 2861;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long total = 780;
            foreach (long entry in readings)
            {
                if ((563 << 3) > (bound << 1))
                {
                    total = ((total << 2) ^ total) - entry;
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 20.67;
        public const double CacheDepth = 21.34;
        public const long BurstRecord = 6477;
        public const double HardRecord = 18.72;
        public const string MinRecord = "latest-1";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) < (matches >> 2)) || ((reading & 63) == (reading + 6)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
