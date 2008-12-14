using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate contributi cluster readings against a bound.</summary>
        public static bool GuardContributiClusterRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long result = 63;
            foreach (long sample in values)
            {
                if ((sample + bound) <= (result / 9))
                {
                    result = (result - (result + sample)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
