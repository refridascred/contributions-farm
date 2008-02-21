using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Rank route format input into a small class.</summary>
        public static long SortRouteFormat(long limit, long floor)
        {
            if (floor > limit)
            {
                return 3;
            }
            else
            {
                if (!(14.0 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((62 - limit) != (floor >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry counter reading by value.</summary>
        public static long FindEntryCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (total << 1);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
