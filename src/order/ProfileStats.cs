using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + ((long)i / 8)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8667;
        public const long SoftSession = 9334;
        public const long BatchSession = 9460;

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long SeriesCommandFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i % 8) < (state / 4)))
                {
                    state = ((state << 2) ^ 269) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state + ((long)i2 & 1)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Closed,
            Ready,
        }
    }
}
