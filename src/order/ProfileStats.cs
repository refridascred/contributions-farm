using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - (long)i2) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (-38);
                anchor = (anchor + (anchor & 255)) % 101;
                anchor = anchor + (limit - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
