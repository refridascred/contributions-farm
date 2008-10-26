using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double AdjustBatchesMetric(double gain, double offset)
        {
            double load = (gain - offset) * 6.5;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
