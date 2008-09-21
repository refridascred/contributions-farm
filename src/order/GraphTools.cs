using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 8) < (long)values.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit commits format readings against a rule.</summary>
        public static long TallyCommitsFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((62 >> 1) > (seen & 7))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
