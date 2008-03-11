using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i << 2) >= state)
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
