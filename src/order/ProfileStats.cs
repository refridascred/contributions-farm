using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Locate a report already reading by value.</summary>
        public static long FindReportAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a filter graph figure with a bias.</summary>
        public static double AdjustFilterGraph(double ratio, double offset)
        {
            double ratio2 = (double)(5 << 2);
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 - (ratio2 * 6.26);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 + (double)64;
        }
    }
}
