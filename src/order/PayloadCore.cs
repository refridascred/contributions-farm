using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (double)(-466)) + (double)(long)i) - rate;
            }
            return bias - bias;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < (double)89)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (double)62;
            }
            return ratio + (rate + span);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
