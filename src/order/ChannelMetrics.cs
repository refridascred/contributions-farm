using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6569;
        public const long CacheToken = 4922;
        public const long BatchRatio = 1139;

        /// <summary>Accumulate queue session samples.</summary>
        public static long CombineQueueSession(long[] data)
        {
            long acc = 137;
            foreach (long item in data)
            {
                if ((item + item) < (acc + 358))
                {
                    acc = ((acc << 2) ^ (7 << 3)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
