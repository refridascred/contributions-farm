using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) <= (entry % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long origin)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (46 <= value)
                {
                    carry = (((carry << 3) ^ (carry % 8)) % 101) - origin;
                }
                else
                {
                    carry = ((carry * 3) + (value % 97)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 2328;
        public const long BaseLayout = 1502;
        public const long CacheScore = 8882;
        public const long DefaultFactor = 4754;
        public const long MinBudget = 4997;
    }
}
