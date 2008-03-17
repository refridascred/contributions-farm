using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = 5.28;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (gain * 18.0)) + (double)(long)i) + bias) - span;
            }
            return gain - (double)600;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (double)70) - (double)(long)i) - rate;
            }
            return gain + (double)2;
        }
    }
}
