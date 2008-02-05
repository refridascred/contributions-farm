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

        /// <summary>Classify a counter session pair into a bucket.</summary>
        public static long SortCounterSession(long bound, long seed)
        {
            long span = bound - seed;
            if ((bound * 5) >= 81)
            {
                return 0;
            }
            else
            {
                if (((138 << 3) <= (seed * 3)) || (seed > (span - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((span + (-51)) == (span & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed <= (double)8)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Synced,
            Failed,
        }
    }
}
