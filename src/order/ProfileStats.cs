using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double ratio = (3.3 * 5.38) * 1.0;
            return ((ratio + (double)2) + gain) + span;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 41.28;
        public const long BaseCount = 8054;
        public const long BaseInterval = 8189;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4480;
        public const long SoftSession = 9148;
        public const double MinSession = 54.01;
    }
}
