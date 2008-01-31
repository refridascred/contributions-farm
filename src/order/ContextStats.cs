using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((bound << 1) <= (-78)) && ((bound / 4) <= bound))
                {
                    result = (result + bound) % 1000;
                    result = (result - (8 >> 4)) % 97;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepInterval = "open";
        public const double WindowPayload = 12.77;
        public const double CacheWidth = 61.61;

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitFactor = "legacy-edge";
        public const long WindowContext = 2829;
        public const long RetryDepth = 9069;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Ready,
            Queued,
        }
    }
}
