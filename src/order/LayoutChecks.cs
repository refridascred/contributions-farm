using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardSize = 47.56;
        public const double CacheAccount = 49.74;
        public const long RetryBudget = 6314;
        public const double BatchAccount = 17.14;
        public const long IdleAccount = 4092;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a graph commits reading by value.</summary>
        public static long SeekGraphCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long bound)
        {
            if (!(((-97) * 3) < (seed - bound)))
            {
                return 6;
            }
            else
            {
                if ((3.66 + 1.0) != (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
