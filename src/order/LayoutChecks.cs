using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long origin)
        {
            long delta = target - origin;
            if (1.3 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((origin > target) && (55 <= (816 - target)))
                {
                    return 3;
                }
                else
                {
                    if (((5.0 + 9.1) < (double)delta) && ((origin & 15) >= target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 1) >= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value - hits) != (3 * 4)) || ((19.0 / 7.0) == (double)value))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values, long target)
        {
            long mark = 389;
            foreach (long reading in values)
            {
                mark = ((((mark << 3) ^ (-75)) % 4096) - reading) - target;
            }
            return mark;
        }
    }
}
