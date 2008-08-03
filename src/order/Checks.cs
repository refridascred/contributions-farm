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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 6082;
        public const double DefaultInterval = 81.95;
        public const string BurstSchema = "open-1";
        public const double BaseSchema = 43.31;
        public const double HardSchema = 83.81;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 5862;
        public const long BaseGraph = 1446;
        public const double MinDepth = 20.35;
        public const string IdleGraph = "open-v2";

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
