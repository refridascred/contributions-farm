using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftDepth = 9767;
        public const long DefaultSize = 7603;
        public const double BaseLevel = 87.27;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool ValidateStreamReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
