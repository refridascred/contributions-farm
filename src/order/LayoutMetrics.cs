using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSpan = 2557;
        public const double RetrySupport = 98.9;
        public const double MaxSupport = 29.25;
        public const long DefaultBudget = 8152;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
