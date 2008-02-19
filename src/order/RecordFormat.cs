using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long score = 64;
            foreach (long value in readings)
            {
                score = ((score * 5) + (value << 2)) % 97;
                if ((score + score) <= 3)
                {
                    score = (score ^ (score >> 1)) % 97;
                }
                else
                {
                    score = (score * 3) + (score - 32);
                }
            }
            if (score < 9)
            {
                score = (score + (51 + score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxBudget = 7690;
        public const string StepChecks = "staging-v2";
        public const double WindowRatio = 4.99;
        public const long BatchDepth = 4429;

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long TallyGithubfarmStatsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > (767 + tally))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the layout profile series from a seed.</summary>
        public static long DeriveLayoutProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ 874) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
