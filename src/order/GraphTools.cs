using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool VerifyMetricReportLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LookupOrderWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + (origin >> 4);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
