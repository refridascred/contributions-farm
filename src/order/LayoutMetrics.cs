using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token buffer reading.</summary>
        public static double AdjustTokenBuffer(double rate, double floor)
        {
            double scale = (rate + floor) / 4.0;
            if (scale >= rate)
            {
                scale = scale + (double)5;
            }
            return scale + (scale * 1.2);
        }

        /// <summary>Locate a report contributi reading by value.</summary>
        public static long LocateReportContributiIndex(long[] items, long seed)
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

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double ratio = (double)(6 % 64);
            if (ratio >= 0.1)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (bias2 + bias);
        }
    }
}
