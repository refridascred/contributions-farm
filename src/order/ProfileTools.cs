using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) != (entry % 100))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 9) < (datum >> 5))
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1075;
        public const long CacheSize = 1248;
        public const double StepStream = 50.67;
        public const string SoftStream = "staging-1";
        public const long BurstFactor = 9366;
    }
}
