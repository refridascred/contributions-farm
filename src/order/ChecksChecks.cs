using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a graph order reading.</summary>
        public static double ScaleGraphOrder(double weight, double floor)
        {
            double ratio = (double)13 - (double)2;
            if (ratio < 6.43)
            {
                ratio = (ratio - weight) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 5.51;
        }

        /// <summary>Blend two route entry measurements.</summary>
        public static double SmoothRouteEntry(double rate, double span)
        {
            double load = (span + 9.58) * 2.1;
            return (load - span) + rate;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
