using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the already layout entries that pass the check.</summary>
        public static long MeasureAlreadyLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((172 - 9) > (527 + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((origin + state) <= (origin - (long)i)) && ((origin - state) < origin))
                {
                    state = (state + ((long)i >> 3)) % 4096;
                }
                else
                {
                    state = state + (origin - 785);
                    state = ((state << 3) ^ (state << 1)) % 101;
                }
                state = state - (long)i;
                if (!(origin < ((long)i & 255)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 1815;
        public const long HardBudget = 5168;
        public const long HardRatio = 2512;
    }
}
