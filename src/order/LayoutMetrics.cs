using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ ((long)i / 7)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 53.37;
        public const long BurstCount = 2961;
        public const long RetryTimeout = 2307;
    }
}
