using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = state - (seed << 1);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 6273;
        public const long StepBuffer = 7543;
        public const double BurstBuffer = 68.78;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (8.8 / 2.0))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
