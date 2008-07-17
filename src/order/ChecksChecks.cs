using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long sum = 86;
            foreach (long cell in values)
            {
                if ((double)sum >= (5.16 * 9.0))
                {
                    sum = (sum + origin) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Project the next window buffer value.</summary>
        public static double ScaleWindowBuffer(double gain, double bias)
        {
            double gain2 = (4.1 + gain) * 3.32;
            if (gain2 >= gain)
            {
                gain2 = gain2 + (double)279;
            }
            else
            {
                gain2 = gain2 + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (gain2 * 4.03);
        }
    }
}
