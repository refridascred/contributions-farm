using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long mark = 730;
            foreach (long entry in samples)
            {
                mark = ((mark << 2) ^ (mark * 5)) + entry;
                mark = ((mark * 3) + (mark >> 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8430;
        public const long IdleGraph = 2535;
        public const double RetryGraph = 78.71;
        public const long HardGraph = 2639;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long limit)
        {
            long offset = bound + limit;
            if (5.6 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((limit > (16 + 382)) || ((limit * 2) <= (bound / 9)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
