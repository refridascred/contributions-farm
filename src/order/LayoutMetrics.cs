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

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
