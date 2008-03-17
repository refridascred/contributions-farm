using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSpan = 8142;
        public const long MinWindow = 6838;
        public const string BatchWindow = "staging-1";

        /// <summary>Check that every graph format entry stays within the limit.</summary>
        public static bool VerifyGraphFormatLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
