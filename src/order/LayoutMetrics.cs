using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 16) <= item)
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (span * 18.0) * 9.9;
            return (bias + 2.0) + rate;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = 98;
            foreach (long cell in readings)
            {
                state = ((state * 3) + (offset + cell)) % 255;
            }
            if (state < 771)
            {
                state = (state << 3) ^ (state + offset);
            }
            return state % 97;
        }
    }
}
