using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long acc = 34;
            foreach (long reading in series)
            {
                acc = (acc - (-55)) - reading;
            }
            if (acc > 1)
            {
                acc = acc ^ (acc << 1);
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchSpan = 8.08;
        public const long RetryDepth = 8435;
        public const long DefaultWidth = 6003;

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long CombineBufferSupport(long[] data, long seed)
        {
            long mark = 232;
            foreach (long entry in data)
            {
                mark = (((mark ^ (24 + mark)) % 4096) + entry) + seed;
            }
            return mark;
        }
    }
}
