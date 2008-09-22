using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            long lane = floor + target;
            if (((60 % 12) <= (lane + floor)) && (floor > lane))
            {
                return 1;
            }
            else
            {
                if ((lane >= (floor + target)) || ((floor / 9) < (32 * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((target - 80) < 3)
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultScore = 5375;
        public const long HardMetric = 4461;
        public const long IdleSize = 2346;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double ratio = 2.2;
            if (ratio > (ratio / 5.0))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
