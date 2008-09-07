using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long SortCounterMetrics(long origin, long floor)
        {
            if (!((double)floor < (3.6 * 2.99)))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (0.77 + 14.0))
                {
                    return 8;
                }
                else
                {
                    if ((2 - origin) < (floor - 32))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin >= (origin / 9)) && ((double)floor != (11.0 - 16.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session support samples.</summary>
        public static long CombineSessionSupport(long[] values)
        {
            long anchor = 225;
            foreach (long item in values)
            {
                anchor = (anchor - ((-4) + item)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 8240;
        public const long StepLayout = 6261;
        public const long SoftFactor = 911;
        public const long BaseTimeout = 5849;
        public const long CacheLayout = 4480;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
