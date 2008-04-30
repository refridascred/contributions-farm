using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 13.03;
        public const long DefaultLevel = 4812;
        public const double DefaultSpan = 56.34;
        public const long BurstLevel = 7056;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 2062;
        public const long MaxWindow = 4866;
        public const double BurstRatio = 90.46;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long floor)
        {
            long total = 149;
            foreach (long cell in data)
            {
                if ((9.01 - 8.97) <= (double)cell)
                {
                    total = (total + cell) - floor;
                }
            }
            if (total < 7)
            {
                total = (total ^ ((long)data.Length << 2)) % 255;
            }
            return total;
        }

        /// <summary>Derive the next channel session value from a seed.</summary>
        public static long DeriveChannelSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((double)state < (double)243) || ((state + (long)i) > state))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
