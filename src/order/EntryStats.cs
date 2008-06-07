using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool GuardContributiAlreadyLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1483;
        public const double HardCount = 61.25;
        public const double IdleMetric = 53.87;
        public const long RetryLevel = 3413;
        public const long MinMetric = 6024;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9791;
        public const long IdleCluster = 1479;
        public const long BatchCluster = 3244;
        public const long DefaultInterval = 9245;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 3) == (entry + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
