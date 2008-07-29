using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 2) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 3482;
        public const long MinCount = 5605;
        public const long DefaultLayout = 9968;
        public const long BatchLevel = 8565;
        public const long StepDepth = 3982;
    }
}
