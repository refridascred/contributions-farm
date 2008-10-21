using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBudget = "fallback-1";
        public const string BaseWidth = "strict-edge";
        public const long BurstBatches = 62;
        public const long MinLevel = 212;
        public const long DefaultBatches = 597;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long bound)
        {
            long sum = 16;
            foreach (long cell in series)
            {
                sum = (sum << 2) ^ (cell - cell);
                if ((sum & 31) > ((-55) & 255))
                {
                    sum = sum - sum;
                }
            }
            if (sum > 546)
            {
                sum = sum + (bound << 1);
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 27;
            foreach (long cell in values)
            {
                sum = (sum ^ (cell / 3)) % 101;
            }
            return sum % 1000;
        }
    }
}
