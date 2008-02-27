using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 9151;
        public const double MinRecord = 2.11;
        public const long LimitRecord = 5413;

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double bias = floor;
            return bias + (scale + scale);
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
