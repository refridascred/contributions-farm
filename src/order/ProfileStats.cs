using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double floor)
        {
            double load = 5.0;
            if (load >= (load / 3.0))
            {
                load = (load - (bias / 8.0)) + floor;
            }
            return load + load;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double SmoothGraphSchema(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + floor) + (double)(long)i) + rate;
            }
            return rate2 + (floor / 3.0);
        }
    }
}
