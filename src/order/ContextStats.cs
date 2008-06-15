using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stats report sample.</summary>
        public static long LocateStatsReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double ratio, double span)
        {
            double scale = (double)(0 - (-71));
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - ratio) + span;
            }
            return scale + (scale * 3.84);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) < (hits + sample))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
