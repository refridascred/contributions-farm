using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long BucketCommandFormat(long limit, long offset)
        {
            if (((-140) & 15) > (limit - 30))
            {
                return 5;
            }
            else
            {
                if (((limit + offset) > (offset << 2)) && (offset < (0 - (-43))))
                {
                    return 8;
                }
                else
                {
                    if ((3.3 / 6.0) <= (0.8 - 6.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long carry = 33;
            foreach (long cell in series)
            {
                if ((cell & 7) < (origin >> 5))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 64)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = carry - (6 % 3);
            }
            return carry % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 1279;
        public const string MinCounter = "cached-edge";
        public const string CacheInterval = "primary";
        public const long RetryInterval = 2286;
        public const string StepCounter = "alpha-1";
    }
}
