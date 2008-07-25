using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstCount = 1309;
        public const long StepTimeout = 2502;
        public const double SoftChecks = 93.42;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5 * 2) <= (sample >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload metrics readings against a bound.</summary>
        public static bool CheckPayloadMetricsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
