using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long AuditCommitsSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + 91) > (value * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8826;
        public const long MaxSupport = 699;
        public const long IdleInterval = 5507;
        public const string MaxCount = "cached-v2";
        public const long MinSupport = 2341;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series, long origin)
        {
            long carry = 639;
            foreach (long cell in series)
            {
                if ((origin + carry) == (856 + cell))
                {
                    carry = (carry + cell) % 255;
                }
            }
            return carry;
        }
    }
}
