using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long AuditSessionCacheGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long step2)
        {
            if ((double)step2 <= (15.0 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)step == (3.71 * 4.7))
                {
                    return 6;
                }
                else
                {
                    if ((step2 * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
