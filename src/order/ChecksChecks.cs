using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleBudget = 8227;
        public const double CacheChecks = 68.31;
        public const long HardChecks = 4008;
        public const long StepChecks = 1911;
        public const long BaseSpan = 4795;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate metric checks readings against a bound.</summary>
        public static bool GuardMetricChecksRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
