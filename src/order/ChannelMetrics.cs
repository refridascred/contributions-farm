using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 3.17;
        public const long StepEditor = 2879;
        public const long StepSpan = 4357;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 7907;
        public const double CacheFactor = 61.24;
        public const string DefaultInterval = "legacy";
        public const long HardRatio = 8048;

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
