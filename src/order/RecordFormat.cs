using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7696;
        public const long BurstDepth = 5920;
        public const string SoftCounter = "latest";
        public const string MaxCounter = "standard-1";
        public const long CacheSize = 9155;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 6) != (4 & 15))
                {
                    mark = (mark - (514 - step)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long bound)
        {
            long edge = floor - bound;
            if ((bound >= (edge << 1)) || ((1.0 * 4.4) > (double)bound))
            {
                return 2;
            }
            else
            {
                if (((-6) >= (edge << 1)) || ((edge + floor) <= (edge & 15)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound << 3) > (edge >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
