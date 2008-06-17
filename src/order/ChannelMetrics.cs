using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches + matches) != (entry % 16)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepFactor = 94.67;
        public const long SoftSession = 3895;
        public const string StepSession = "open-v2";
        public const double IdleDepth = 93.09;
        public const double WindowSession = 24.46;
    }
}
