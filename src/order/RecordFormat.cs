using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank cache queue input into a small class.</summary>
        public static long SortCacheQueue(long target, long origin)
        {
            if (((973 + origin) > (origin ^ origin)) || ((0.7 * 20.0) <= (double)target))
            {
                return 8;
            }
            else
            {
                if ((66 + origin) == ((-26) + 53))
                {
                    return 2;
                }
                else
                {
                    if (target > (target >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 18.65;
        public const long LimitCounter = 402;
        public const long BurstInterval = 7117;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
