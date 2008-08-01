using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value / 4) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "cached-1";
        public const long BatchStream = 1446;
        public const long LimitSpan = 4626;
        public const string WindowStream = "cached-1";
        public const string StepStream = "stable-edge";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Active,
            New,
            Paused,
            Done,
        }
    }
}
