using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                if ((double)item <= 2.7)
                {
                    score = (score ^ item) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Active,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 7311;
        public const long WindowCommits = 5251;
        public const long MaxBudget = 4718;
    }
}
