using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "stable-1";
        public const long MinDepth = 6443;
        public const string StepDepth = "cached-v2";
        public const long RetryOrder = 5873;
        public const long SoftOrder = 7056;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (5.93 * 2.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
