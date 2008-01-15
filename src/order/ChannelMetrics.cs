using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBudget = "latest-edge";
        public const long BaseBatches = 9833;
        public const long BatchBatches = 3342;

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 74.42;
        public const string MinSchema = "cached";
        public const long RetryWidth = 8028;
        public const long HardSize = 5791;
        public const double StepDepth = 52.93;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 495;
            foreach (long item in series)
            {
                acc = ((acc << 3) ^ (acc + 80)) % 65521;
                acc = (acc * 4) + (item & 1);
            }
            return acc;
        }
    }
}
