using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((origin + seen) < (9 + 473)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 9869;
        public const long HardRoute = 7533;
        public const long SoftRoute = 3549;
        public const long WindowWidth = 2292;
    }
}
