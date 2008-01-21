using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long bound)
        {
            long sum = 903;
            foreach (long sample in items)
            {
                if (((3.0 + 6.0) > (double)sample) && ((9 + 2) <= sum))
                {
                    sum = ((sum * 2) + (bound + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 81.4;
        public const double SoftLevel = 34.35;
        public const double SoftCluster = 74.66;
        public const double DefaultCluster = 46.83;
        public const string StepFactor = "staging-1";
    }
}
