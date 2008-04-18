using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (offset < (state + (long)i))
                {
                    state = (state << 2) ^ offset;
                    continue;
                }
                state = (state * 4) + (offset % 7);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a layout notes counter forward.</summary>
        public static long IterateLayoutNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (result * 2)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long floor)
        {
            long result = 981;
            foreach (long entry in samples)
            {
                if (!((4.46 - 9.1) < (double)entry))
                {
                    result = ((result + (result % 60)) % 255) - floor;
                }
            }
            if (result < 52)
            {
                result = ((result << 2) ^ (result >> 5)) % 97;
            }
            return result % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double ratio = (offset + 6.0) * 5.46;
            return (ratio - (6.4 * 9.3)) + scale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstWidth = 46.31;
        public const double BurstRatio = 80.34;
        public const long BaseOrder = 9470;
        public const long CacheOrder = 1608;
    }
}
