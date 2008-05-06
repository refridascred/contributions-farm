using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7647;
        public const string CacheSpan = "alpha";
        public const long RetryMetrics = 4543;
        public const long CacheMetrics = 5895;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
