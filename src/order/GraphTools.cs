using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long AuditCounterSupportOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((4.0 + 9.66) < (double)bound) || ((19.0 * 9.58) > (double)value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((1.99 / 2.0) < (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Active,
            Stale,
        }
    }
}
