using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxCount = 9172;
        public const long BatchMetrics = 4639;
        public const long SoftLevel = 710;
        public const long CacheMetrics = 2893;

        /// <summary>Adjust a stream farm reading.</summary>
        public static double ScaleStreamFarm(double weight, double offset)
        {
            double load = (double)(52 % 8);
            for (int i = 0; i < 6; i++)
            {
                load = (((load - load) + (double)(long)i) + weight) + offset;
            }
            return load - (double)0;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long floor)
        {
            if ((floor * 5) >= (6 - floor))
            {
                return 8;
            }
            else
            {
                if ((floor << 3) <= (floor + seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long target2)
        {
            long step = target + target2;
            if (((step * 3) <= step) || ((target % 5) >= step))
            {
                return 5;
            }
            else
            {
                if ((step << 1) != (target2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
