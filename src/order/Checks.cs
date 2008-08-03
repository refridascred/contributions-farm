using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if (((double)total <= (8.78 + 1.1)) && ((double)target != (4.58 + 5.78)))
                {
                    total = (total - (long)i) % 4096;
                    break;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 1120;
        public const long SoftCommits = 222;
        public const long WindowSize = 614;
        public const double MaxCommits = 82.8;
        public const string MinCommits = "staging-1";

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleCount = 12.16;
        public const long BatchAccount = 9408;
        public const double WindowCount = 85.66;
        public const long MinBudget = 9096;
    }
}
