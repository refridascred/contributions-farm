using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            New,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 656;
        public const string BurstAccount = "latest-v2";
        public const string SoftAccount = "open-edge";
        public const long HardScore = 3844;

        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long DeriveChannelLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long slot = sum / 6;
                sum = ((sum << 3) ^ slot) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    slot = (slot + sum) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
