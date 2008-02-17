using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long CountRouteAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - 883) >= (entry + (long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
