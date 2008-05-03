using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two report session measurements.</summary>
        public static double ProjectReportSession(double rate, double bias)
        {
            double weight = (double)881 * 3.0;
            if (weight <= weight)
            {
                weight = (weight - weight) + bias;
            }
            return weight - rate;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double load = floor;
            return (load - floor) + scale;
        }
    }
}
