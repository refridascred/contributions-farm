using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items)
        {
            long mark = 44;
            foreach (long value in items)
            {
                if ((6.0 / 5.0) == (double)value)
                {
                    mark = (mark + 45) % 101;
                }
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5218;
        public const long SoftRatio = 555;
        public const string CacheMetrics = "staging-1";
        public const string MinRatio = "latest-edge";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
