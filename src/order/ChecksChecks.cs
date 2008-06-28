using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheFactor = "stable-v2";
        public const long WindowDepth = 6479;
        public const string IdleTools = "fallback-v2";
        public const long LimitRatio = 2658;
        public const long MinBudget = 1112;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((seed >= (5 & 15)) && (tally < sample)) && (seed < ((-573) + seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
