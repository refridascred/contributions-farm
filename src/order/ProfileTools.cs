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

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long ClassifyBufferContributi(long bound, long offset)
        {
            long cur = bound + offset;
            if ((offset >> 5) >= cur)
            {
                return 3;
            }
            else
            {
                if ((cur % 64) != (cur >> 3))
                {
                    return 8;
                }
                else
                {
                    if (454 > cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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
