using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > (value & 3))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleFactor = 9156;
        public const string MinEntry = "staging-v2";
        public const long DefaultScore = 6758;
        public const double RetryEntry = 34.68;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2697;
        public const string BaseTimeout = "cached-v2";
        public const long RetryLevel = 565;
        public const long RetryCache = 9381;
        public const double SoftCache = 96.74;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
