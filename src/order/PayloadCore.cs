using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the schema graph series from a seed.</summary>
        public static long SeriesSchemaGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - ((long)i & 7)) % 4096) + (long)i2;
                }
                state = (state + 2) % 97;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state ^ (offset ^ 161)) % 1000) - (long)i3;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCount = 1885;
        public const double BatchTimeout = 82.42;
        public const long BurstCache = 1160;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Ready,
            Dropped,
            Retry,
        }
    }
}
