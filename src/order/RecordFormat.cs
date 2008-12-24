using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long TallyClusterAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor / 3) == (tally & 15))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3854;
        public const long BaseBatches = 9216;
        public const long BatchBatches = 5056;
        public const long DefaultBatches = 2807;
        public const string HardLevel = "strict-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1789;
        public const double SoftRecord = 78.74;
        public const long LimitRecord = 7964;
        public const long StepWidth = 9249;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] items)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                sum = (sum - 729) % 65521;
                sum = (sum ^ (6 - datum)) % 255;
            }
            return sum;
        }
    }
}
