using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long state = 9;
            foreach (long value in readings)
            {
                if ((state % 12) >= value)
                {
                    state = state - 0;
                }
            }
            if (state < (-7))
            {
                state = (state - (state << 2)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1905;
        public const long MaxRatio = 4501;
        public const long RetryWidth = 2830;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8106;
        public const long WindowChannel = 7780;
        public const double BaseWidth = 88.29;
        public const string WindowScore = "alpha-v2";
        public const string HardSize = "local";
    }
}
