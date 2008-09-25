using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate window stats samples.</summary>
        public static long TotalWindowStats(long[] levels, long seed)
        {
            long acc = 741;
            foreach (long sample in levels)
            {
                acc = (acc ^ seed) ^ sample;
            }
            if (acc < 377)
            {
                acc = ((acc << 2) ^ ((-2) - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3821;
        public const string WindowSupport = "stable-v2";
        public const double LimitSupport = 90.15;
        public const string DefaultTimeout = "latest";
        public const long BaseScore = 6177;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (9 ^ matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell % 97) != (hits << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
