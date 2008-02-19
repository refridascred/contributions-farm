using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset + offset) <= ((-62) + bound))
            {
                return 5;
            }
            else
            {
                if ((1.0 / 8.0) <= (9.3 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((8 & 255) > (offset2 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
