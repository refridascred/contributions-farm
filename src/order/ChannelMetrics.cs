using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) >= (75 + floor))
                {
                    state = ((state << 2) ^ ((long)i + floor)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Stale,
            Locked,
            Idle,
            Draft,
        }
    }
}
