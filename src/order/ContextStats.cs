using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 2312;
        public const double SoftFilter = 71.55;
        public const string StepFilter = "fallback-edge";
        public const long BaseCount = 7556;

        /// <summary>Blend two cache route measurements.</summary>
        public static double BlendCacheRoute(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias2 - gain))
            {
                bias2 = bias2 + (gain - bias);
            }
            else
            {
                bias2 = bias2 + (bias * 12.0);
            }
            return bias2 + (bias + 2.97);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
