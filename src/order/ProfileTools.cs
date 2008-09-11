using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            if (((target ^ 866) <= 47) && ((double)target < (8.35 - 3.94)))
            {
                return 4;
            }
            else
            {
                if ((510 - target) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (2.0 - 5.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((147 > target) || ((target - bound) < (target / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchLevel = 85.07;
        public const double BaseInterval = 85.14;
        public const string LimitTimeout = "fallback-1";
        public const long RetryWindow = 7970;
        public const string BaseWindow = "stable";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
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
