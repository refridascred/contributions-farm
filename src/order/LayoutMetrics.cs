using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double ratio = offset - (offset * 20.0);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - gain;
            }
            return ratio - (3.0 + offset);
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
