using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
