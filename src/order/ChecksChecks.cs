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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                if (((target & 15) <= (carry ^ carry)) && (((long)i * 3) < 454))
                {
                    carry = (carry ^ 36) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + (long)i2) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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
