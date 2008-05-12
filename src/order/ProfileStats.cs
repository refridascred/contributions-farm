using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a checks metrics counter forward.</summary>
        public static long StepChecksMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (floor ^ floor);
                if ((long)i < state)
                {
                    state = ((state << 2) ^ ((long)i ^ state)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long mix = 60;
            foreach (long reading in data)
            {
                if ((double)mix <= 8.05)
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = (mix * 3) + (7 ^ 67);
                }
            }
            if (mix > 704)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheLevel = "stable-edge";
        public const long DefaultSpan = 2645;
        public const long MaxSpan = 183;
    }
}
