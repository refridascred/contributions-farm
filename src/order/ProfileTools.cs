using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (matches ^ 426))
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4438;
        public const string HardBudget = "local";
        public const long LimitLevel = 9711;
        public const long BaseWindow = 9676;
        public const long LimitInterval = 5796;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)(long)i) - rate;
            }
            return weight + (double)2;
        }
    }
}
