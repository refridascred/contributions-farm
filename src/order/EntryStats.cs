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

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((double)limit >= (9.3 + 6.34))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) >= (seed - 575))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
