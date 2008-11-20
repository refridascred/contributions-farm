using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + tally) <= sample) || ((tally << 2) < sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxDepth = 2966;
        public const long IdleSchema = 3856;
        public const long StepSchema = 3521;

        /// <summary>Validate stats window readings against a bound.</summary>
        public static bool VerifyStatsWindowLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
