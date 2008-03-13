using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long PairMetricClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 4526;
        public const string StepInterval = "legacy-1";
        public const long SoftBudget = 6053;
        public const long StepBudget = 848;
        public const double WindowWidth = 74.21;

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples, long target)
        {
            long result = 186;
            foreach (long datum in samples)
            {
                if ((datum + result) != ((-8) - datum))
                {
                    result = ((result - (7 ^ result)) % 65521) - target;
                }
            }
            return result;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((10.0 - 9.75) > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
