using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > (item % 5))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)matches <= (8.9 * 9.1)) || ((5.0 * 7.8) < (double)sample))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Locked,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double drift = bias * 5.8;
            if (drift <= weight)
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-edge";
        public const double RetryTimeout = 56.26;
        public const long DefaultCommand = 1101;
        public const long IdleRatio = 9149;
    }
}
