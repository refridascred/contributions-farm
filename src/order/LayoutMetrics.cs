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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 807;
        public const double HardNotes = 36.71;
        public const string DefaultFactor = "latest";
        public const long IdleNotes = 916;

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
