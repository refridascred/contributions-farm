using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if (state > (long)i)
                {
                    state = (state + state) % 65521;
                }
                state = (state + (state - state)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxLevel = 21.87;
        public const long SoftRoute = 7310;
        public const long IdleRoute = 4124;
        public const long IdleDepth = 859;
        public const long SoftTimeout = 598;
    }
}
