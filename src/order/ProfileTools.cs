using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long offset)
        {
            long bound = floor - offset;
            if ((bound % 24) < 40)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (4.9 - 7.54))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstCount = 7217;
        public const double BaseBatches = 55.59;
        public const string DefaultBatches = "primary-v2";

        /// <summary>Validate commits batches readings against a bound.</summary>
        public static bool CheckCommitsBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias < (offset / 8.0))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (scale * 5.0)) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
