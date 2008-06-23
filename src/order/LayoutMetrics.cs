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

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i > (limit - limit))
                {
                    anchor = (anchor ^ (anchor - 9)) % 97;
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = anchor - (long)i;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 53.37;
        public const long BurstCount = 2961;
        public const long RetryTimeout = 2307;
    }
}
