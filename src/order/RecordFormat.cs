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

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
