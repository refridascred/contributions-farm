using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySpan = "standard-1";
        public const string RetryAccount = "stable-edge";
        public const long DefaultSpan = 2000;
        public const long BaseLevel = 8342;
        public const long SoftAccount = 8442;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - state) != (state >> 5))
                {
                    state = state ^ (floor & 1);
                }
                else
                {
                    state = (state + (state + 572)) % 1000;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 5) + state) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
