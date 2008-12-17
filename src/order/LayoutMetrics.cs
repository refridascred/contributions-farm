using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits window reading.</summary>
        public static double BlendCommitsWindow(double gain, double offset)
        {
            double load = (double)(41 & 127);
            return ((load - (double)89) + gain) + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSpan = 6.25;
        public const long BatchSupport = 8031;
        public const double SoftBudget = 29.72;
        public const long WindowSupport = 9056;
    }
}
