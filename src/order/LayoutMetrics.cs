using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit ^ 96) == (limit & 1))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftLevel = 2292;
        public const long DefaultInterval = 6534;
        public const long BurstMetrics = 697;
        public const double MinMetrics = 15.48;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ 7) > (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
