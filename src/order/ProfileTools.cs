using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long state = 11;
            foreach (long item in data)
            {
                if (!(item > (state ^ item)))
                {
                    state = (state * 3) + (item + item);
                }
            }
            return state;
        }

        /// <summary>Project the next batches record value.</summary>
        public static double AdjustBatchesRecord(double weight, double bias)
        {
            double ratio = (double)(21 + (-498));
            if (ratio >= bias)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)649;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias - weight)) + (double)(long)i;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9135;
        public const long IdleLevel = 5918;
        public const long BurstRatio = 2656;
        public const long RetryLevel = 3694;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Queued,
            Failed,
            New,
        }
    }
}
