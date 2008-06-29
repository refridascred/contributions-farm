using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels, long seed)
        {
            long carry = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 2) ^ (carry + item)) % 1000) ^ (long)i;
                }
                carry = (carry ^ (seed + carry)) % 1000;
                if ((seed / 9) > (835 + seed))
                {
                    carry = (carry ^ (carry << 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (limit + limit)) % 65521;
                if (score <= limit)
                {
                    score = (score << 3) ^ ((-70) & 3);
                }
                else
                {
                    score = ((score * 4) + (limit >> 1)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
