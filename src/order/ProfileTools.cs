using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit layout stats readings against a rule.</summary>
        public static long MeasureLayoutStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample - matches) > (matches - matches)) && ((matches ^ matches) <= (matches << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Queued,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3639;
        public const long StepReport = 7475;
        public const double IdleReport = 20.94;
        public const double WindowReport = 35.47;
        public const string RetryReport = "alpha-v2";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = (result - (item - result)) % 4096;
            }
            if (result > 70)
            {
                result = result ^ (result * 2);
            }
            return result;
        }
    }
}
