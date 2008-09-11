using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double AdjustMetricPayload(double rate, double offset)
        {
            double drift = (rate - rate) / 4.0;
            return (drift + (1.1 - rate)) + offset;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double drift = weight;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 7.1) + (double)(long)i) - offset;
            }
            return drift - (3.0 / 8.0);
        }
    }
}
