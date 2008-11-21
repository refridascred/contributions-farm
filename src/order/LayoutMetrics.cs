using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                if (((490 + sum) >= sum) && ((datum / 6) > (sum << 3)))
                {
                    sum = sum ^ (843 + datum);
                }
            }
            if (sum > 897)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1644;
        public const double HardBudget = 69.19;
        public const double MaxCommits = 62.4;
    }
}
