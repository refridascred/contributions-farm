using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool GuardQueueMetricRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a batch counter figure with a bias.</summary>
        public static double BlendBatchCounter(double bias, double bias2)
        {
            double load = (bias2 + 5.87) - bias;
            if (load >= (load + load))
            {
                load = load + (bias2 * 14.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias2) - (double)(long)i;
            }
            return load + (3.7 / 9.0);
        }
    }
}
