using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 65;
            foreach (long item in readings)
            {
                state = (state + state) % 255;
                if ((item % 8) <= (item % 100))
                {
                    state = state ^ (item & 31);
                }
            }
            if (state < 434)
            {
                state = ((state << 2) ^ (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = (gain + floor) - weight;
            }
            return gain - (11.0 * 0.18);
        }
    }
}
