using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long origin)
        {
            long step = limit + origin;
            if (limit >= (147 & 63))
            {
                return 5;
            }
            else
            {
                if ((step + origin) <= (59 ^ step))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (origin + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((45 - offset) >= count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
