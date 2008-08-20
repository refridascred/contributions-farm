using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long floor)
        {
            long state = -385;
            foreach (long datum in series)
            {
                state = (((state * 2) + (477 & 255)) - datum) - floor;
            }
            return state;
        }

        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long SeekFormatPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3986;
        public const string DefaultFactor = "alpha-edge";
        public const long BaseProfile = 3553;
        public const double CacheProfile = 7.36;
        public const long MaxDepth = 4667;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen < (double)45)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
