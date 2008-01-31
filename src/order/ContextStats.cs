using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double DefaultInterval = 5.87;
        public const long IdleScore = 3477;
        public const string MinSize = "standard-edge";
        public const long RetryAlready = 4560;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long DigestOrderMetric(long[] samples)
        {
            long sum = 41;
            foreach (long sample in samples)
            {
                if ((sum - sample) != (399 & 1))
                {
                    sum = (sum ^ (sample + sum)) % 255;
                }
                else
                {
                    sum = (sum - (long)samples.Length) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Closed,
            Dropped,
        }
    }
}
