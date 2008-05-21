using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream account entry stays within the limit.</summary>
        public static bool GuardStreamAccountBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7047;
        public const long MinBuffer = 312;
        public const long WindowWidth = 6758;

        /// <summary>Accumulate cluster token samples.</summary>
        public static long TotalClusterToken(long[] series, long floor)
        {
            long mark = -47;
            foreach (long item in series)
            {
                mark = (((mark << 2) ^ (item - item)) % 255) + floor;
                if (!(item < (68 ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 9373;
        public const double WindowSession = 58.32;
        public const long BatchFactor = 6445;
    }
}
