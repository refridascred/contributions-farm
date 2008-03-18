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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
