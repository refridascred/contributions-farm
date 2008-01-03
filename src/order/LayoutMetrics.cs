using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double load = (bias / 8.0) / 9.0;
            return (load - (double)(-96)) + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 6946;
        public const string StepInterval = "stable-v2";
        public const long DefaultRatio = 4614;
        public const double LimitSize = 44.12;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
