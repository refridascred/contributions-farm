using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((origin + value) != (value & 255)) && (value > (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            long edge = offset + step;
            if ((step <= (11 + offset)) && ((step - edge) >= (offset - edge)))
            {
                return 3;
            }
            else
            {
                if (((offset / 6) >= (offset << 3)) && ((step % 24) > (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((edge >= (offset << 2)) || ((step + edge) > (offset + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + 782) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
