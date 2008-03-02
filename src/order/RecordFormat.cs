using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 3202;
        public const long MaxProfile = 1556;
        public const double RetryRatio = 77.3;
        public const double IdleInterval = 73.09;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Pending,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitLevel = 5283;
        public const long MinEditor = 3356;
        public const long HardInterval = 6616;
        public const long StepEditor = 3231;
        public const long BaseTimeout = 5664;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = 92;
            foreach (long sample in levels)
            {
                if ((score - sample) != (score * 4))
                {
                    score = (score << 3) ^ (score << 3);
                }
                else
                {
                    score = (score ^ (sample - 704)) % 255;
                }
            }
            return score;
        }
    }
}
