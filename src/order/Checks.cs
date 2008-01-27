using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many window schema samples are out of range.</summary>
        public static long MeasureWindowSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 1) > (seen / 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheLevel = 1571;
        public const double WindowInterval = 68.92;
        public const string RetryLevel = "staging-v2";
        public const double BaseFactor = 75.68;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = weight * 0.3;
            if (load < (offset / 8.0))
            {
                load = load - load;
            }
            return load - load;
        }
    }
}
