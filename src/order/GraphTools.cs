using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9469;
        public const string BaseTimeout = "alpha-v2";
        public const long LimitAccount = 4785;

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "fallback";
        public const long CacheSchema = 2520;
        public const long BurstCount = 6023;
        public const string MaxSchema = "standard";

        /// <summary>Accumulate command buffer samples.</summary>
        public static long ScoreCommandBuffer(long[] values, long target)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((target * 3) < (entry >> 2))
                {
                    sum = ((sum << 2) ^ entry) % 255;
                }
            }
            if (sum > 1)
            {
                sum = (sum << 2) ^ target;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}
