using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 52.1;
        public const double DefaultEditor = 1.55;
        public const long MaxInterval = 8724;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
