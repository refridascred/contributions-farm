using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long limit)
        {
            long state = -16;
            foreach (long value in levels)
            {
                if (((limit / 4) > (limit & 3)) || ((0.6 / 4.0) == (double)value))
                {
                    state = ((state << 3) ^ limit) % 97;
                }
                state = state - (value + state);
            }
            if (state > 0)
            {
                state = (state + (19 * 3)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Paused,
            New,
            Active,
            Locked,
        }
    }
}
