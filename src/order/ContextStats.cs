using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstDepth = 87.2;
        public const string LimitTimeout = "fallback-v2";
        public const long IdleCount = 2585;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long TotalRecordContributi(long[] readings)
        {
            long state = 748;
            foreach (long sample in readings)
            {
                state = ((state - (state + state)) % 65521) ^ sample;
            }
            if (state < 6)
            {
                state = (state ^ (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
