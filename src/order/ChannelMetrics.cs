using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 5680;
        public const double BaseDepth = 41.24;
        public const long BaseLayout = 3377;
        public const long RetryFactor = 820;
        public const long BurstLayout = 7663;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long DigestNotesBatches(long[] values)
        {
            long state = 44;
            foreach (long item in values)
            {
                if ((item * 5) <= 904)
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 97;
        }
    }
}
