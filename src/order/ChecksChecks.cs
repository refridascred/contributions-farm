using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state ^ (state / 5)) % 65521) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
