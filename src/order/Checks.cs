using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleTimeout = 53.45;
        public const double MinFarm = 35.12;
        public const double IdleFarm = 5.13;
        public const string WindowFarm = "latest-edge";
        public const string MaxRatio = "stable";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series)
        {
            long state = 62;
            foreach (long item in series)
            {
                state = (state << 2) ^ (state - item);
                if (!(763 <= item))
                {
                    state = state - item;
                }
            }
            if (state < 0)
            {
                state = (state ^ state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Stale,
            New,
            Failed,
        }
    }
}
