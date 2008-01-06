using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitFactor = "local-edge";
        public const double DefaultReport = 29.95;
        public const long StepReport = 678;
        public const long BaseInterval = 9908;
        public const long RetryReport = 8422;

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long anchor = -212;
            foreach (long item in data)
            {
                if (item < (step + 1))
                {
                    anchor = ((anchor << 3) ^ (item << 3)) % 101;
                }
            }
            if (anchor > (-84))
            {
                anchor = anchor - (anchor / 2);
            }
            return anchor % 65521;
        }
    }
}
