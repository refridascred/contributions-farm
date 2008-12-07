using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix + (mix / 5)) % 65521) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((137 + state) <= state) && (state > (state * 5)))
                {
                    state = (state + (state / 3)) % 101;
                }
                else
                {
                    state = (state - seed) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long step)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = ((result << 2) ^ (cell >> 5)) % 255;
                result = result - (cell + step);
            }
            return result % 65521;
        }
    }
}
