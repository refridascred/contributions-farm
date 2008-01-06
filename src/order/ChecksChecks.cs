using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 65.22;
        public const string LimitAlready = "primary-edge";
        public const long IdleSpan = 7363;
        public const long IdleInterval = 8737;
        public const string DefaultAlready = "standard-1";

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = state - (573 ^ 654);
                state = ((state << 3) ^ (state & 7)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
