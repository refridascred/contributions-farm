using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((51 - value) > (937 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitCount = 9610;
        public const double MinFactor = 33.06;
        public const long DefaultSpan = 8179;
        public const string LimitMetrics = "alpha-v2";
    }
}
