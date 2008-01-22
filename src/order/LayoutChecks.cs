using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (934 ^ matches)) && ((sample - 3) != (97 + sample)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
