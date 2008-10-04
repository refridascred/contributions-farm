using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((236 & 255) != (matches + entry))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long step)
        {
            if (!(floor >= (step << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (2.22 * 7.9))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
