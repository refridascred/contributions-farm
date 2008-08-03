using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state << 3) ^ (4 + seed);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long target)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if (7.0 >= (double)target)
                {
                    carry = (carry ^ (carry / 6)) % 4096;
                }
                if ((item < (target ^ carry)) || ((8 * 4) > (item >> 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowSpan = 75.65;
        public const long DefaultLevel = 1171;
        public const long StepMetrics = 7706;
        public const string HardMetrics = "standard-edge";
        public const long IdleSpan = 5249;
    }
}
