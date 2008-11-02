using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a command metrics value against two limits.</summary>
        public static long ClassifyCommandMetrics(long floor, long floor2)
        {
            if ((floor & 63) <= 7)
            {
                return 2;
            }
            else
            {
                if ((2.7 / 4.0) > (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (9.2 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long AuditChannelMetricsMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits > seed) || ((hits - datum) == (65 * 4))) || ((double)hits == (3.6 / 8.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
