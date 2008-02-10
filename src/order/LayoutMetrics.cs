using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double load = (double)(76 - (-4));
            if (load <= rate)
            {
                load = load + (17.0 - load);
            }
            return load + offset;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double gain = (double)(8 / 9);
            if (gain <= 8.26)
            {
                gain = (gain - scale) - bias;
            }
            return gain - (gain - gain);
        }
    }
}
