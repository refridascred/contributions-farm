using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double rate = (double)(760 - 31);
            if (rate > (11.0 * 14.0))
            {
                rate = rate + weight;
            }
            return rate + (bias - weight);
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long BucketEntryAlready(long step, long seed)
        {
            if (seed >= (step + step))
            {
                return 1;
            }
            else
            {
                if (step < (step ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 3) > (seed ^ 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2452;
        public const string StepBudget = "standard-1";
        public const string StepWidth = "alpha";
        public const long IdleCount = 8999;
        public const long BurstWindow = 6612;
    }
}
