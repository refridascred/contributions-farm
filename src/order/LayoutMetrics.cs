using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.0 - rate)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
