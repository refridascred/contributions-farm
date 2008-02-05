using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 930;
        public const long MaxContext = 9787;
        public const string MinContext = "primary-1";
        public const string CacheSpan = "latest-edge";
        public const long BurstContext = 8607;

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long bound)
        {
            if (((6.6 / 4.0) == (double)bound) && ((bound * 3) != (bound - step)))
            {
                return 1;
            }
            else
            {
                if ((step % 10) < bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a stream format counter forward.</summary>
        public static long SeriesStreamFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
