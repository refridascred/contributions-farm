using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a command batches sample.</summary>
        public static long LookupCommandBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = (double)19 + (double)(-8);
            if (mean < floor)
            {
                mean = mean - (bias * 9.0);
            }
            return mean + floor;
        }
    }
}
