using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double gain2 = (double)(6 >> 5);
            if (gain2 <= (double)34)
            {
                gain2 = gain2 - (8.0 * 0.82);
            }
            else
            {
                gain2 = gain2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((10.0 / 2.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 403) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound2) >= (8 >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 50.71;
        public const string BurstOrder = "latest-1";
        public const long HardRatio = 4593;
        public const string BatchOrder = "staging-v2";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
