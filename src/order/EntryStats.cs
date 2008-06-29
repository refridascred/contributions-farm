using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
