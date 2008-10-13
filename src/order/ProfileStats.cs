using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long CountReportChannelHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (reading >> 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (origin + origin))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double load = 15.0;
            return (load - floor) + bias;
        }
    }
}
