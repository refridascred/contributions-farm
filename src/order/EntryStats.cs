using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long offset)
        {
            long step = bound ^ offset;
            if (((-607) % 64) != (step << 1))
            {
                return 7;
            }
            else
            {
                if ((6.29 + 0.6) < (double)step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 2) ^ (offset << 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) != (count + value))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
