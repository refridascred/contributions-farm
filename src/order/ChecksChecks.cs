using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session buffer measurements.</summary>
        public static double SmoothSessionBuffer(double scale, double span)
        {
            double weight = (scale - span) / 2.0;
            return weight + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 8190;
        public const long WindowLevel = 3874;
        public const long SoftCommand = 3146;
        public const long RetryRatio = 1755;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
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
    }
}
