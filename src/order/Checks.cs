using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 1003;
        public const long BurstLevel = 1067;
        public const double BatchSpan = 5.77;
        public const long BurstToken = 1333;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double load = 4.25;
            if (load <= rate)
            {
                load = load - load;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - 4.1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)count <= (14.0 - 5.83)))
                {
                    count = ((count + 2) ^ datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "alpha-1";
        public const long WindowTools = 5666;
        public const long LimitFactor = 1058;
        public const long StepTools = 7298;
    }
}
