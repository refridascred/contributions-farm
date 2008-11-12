using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseRatio = 4386;
        public const long MaxSpan = 3323;
        public const long StepFactor = 8958;
        public const long StepWindow = 8773;
        public const double BatchRatio = 26.67;

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
