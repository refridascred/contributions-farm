using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "strict-v2";
        public const long HardBudget = 9615;
        public const string CacheCount = "open-edge";

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data)
        {
            long score = 847;
            foreach (long value in data)
            {
                score = score + (value + value);
            }
            if (score > 5)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if (origin >= (origin - step))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < (origin - 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
