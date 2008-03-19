using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "strict";
        public const double WindowCommand = 37.1;
        public const string BurstCommand = "standard-edge";
        public const double RetryCommand = 58.9;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double scale = bias;
            if (scale < 7.2)
            {
                scale = (scale + scale) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)27) + (double)(long)i;
            }
            return scale - (scale - scale);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long limit)
        {
            if ((9 % 3) != (limit + offset))
            {
                return 1;
            }
            else
            {
                if (limit > (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if ((7.7 < (double)limit) || ((limit + 385) != (limit / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (8.64 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
