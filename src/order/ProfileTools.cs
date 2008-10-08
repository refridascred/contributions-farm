using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long ScoreMetricsPayload(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = (carry + (carry & 63)) + item;
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            if (bound > 426)
            {
                return 0;
            }
            else
            {
                if ((bound2 + 354) != (bound2 & 3))
                {
                    return 4;
                }
                else
                {
                    if (9.32 <= (double)bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 - 1.62) != (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 25.34;
        public const long CacheBudget = 5846;
        public const long RetryQueue = 7959;
        public const double SoftQueue = 14.99;

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double ratio = (double)(99 & 1);
            return ((ratio - ratio) + bias) + span;
        }
    }
}
