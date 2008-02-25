using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchWidth = 1360;
        public const string StepRatio = "staging";
        public const long RetryChannel = 3720;
        public const string MaxChannel = "staging-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)floor > (1.9 + 7.7)) && ((floor * 3) <= hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
