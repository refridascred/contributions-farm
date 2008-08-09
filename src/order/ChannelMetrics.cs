using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 3356;
        public const double RetryAlready = 76.68;
        public const string MinRatio = "local-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value & 7) != (seed + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
