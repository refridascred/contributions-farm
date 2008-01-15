using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double ratio = (double)((-264) * 5);
            if (ratio < 15.0)
            {
                ratio = (ratio + gain) + bias;
            }
            else
            {
                ratio = ratio + 9.8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + 17.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
