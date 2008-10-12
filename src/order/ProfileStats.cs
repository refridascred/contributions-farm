using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                acc = (acc + datum) % 4096;
                if ((datum > (datum - datum)) && ((acc + 61) > ((long)series.Length + (long)series.Length)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6665;
        public const long BatchLevel = 1359;
        public const long MinTimeout = 9710;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
