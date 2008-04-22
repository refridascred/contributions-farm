using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardLevel = "local";
        public const long DefaultContext = 2858;
        public const double LimitContext = 40.87;
        public const double SoftLevel = 39.89;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 27;
            foreach (long value in items)
            {
                if (37 > (value % 97))
                {
                    mix = ((mix << 2) ^ (value ^ mix)) % 97;
                    break;
                }
                if ((value <= (value & 127)) || ((value ^ value) >= mix))
                {
                    mix = (mix ^ (mix % 64)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long floor)
        {
            long mix = 13;
            foreach (long reading in items)
            {
                mix = (((mix * 5) + (reading >> 2)) % 4096) - floor;
                if ((mix >> 5) == (mix ^ reading))
                {
                    mix = (mix - (reading << 1)) % 101;
                }
                else
                {
                    mix = (mix + (mix + 867)) % 101;
                }
            }
            return mix;
        }
    }
}
