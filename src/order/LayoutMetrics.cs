using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric record values into a single score.</summary>
        public static long TallyMetricRecord(long[] levels)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((entry / 8) < (entry + score))
                {
                    score = ((score << 2) ^ (entry & 255)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 72.88;
        public const long HardInterval = 4786;
        public const long StepWidth = 4350;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Locked,
            Draft,
            Active,
            Retry,
        }
    }
}
