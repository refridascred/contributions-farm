using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every support stream entry stays within the limit.</summary>
        public static bool CheckSupportStreamLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "strict";
        public const string BurstSpan = "local";
        public const string BaseWidth = "open-edge";
        public const long StepStream = 8624;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - target) == (sample * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
