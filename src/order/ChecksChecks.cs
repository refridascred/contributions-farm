using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)value < (double)tally) && (origin < (tally >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long bound)
        {
            if ((16.0 / 6.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (bound > (target + target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
