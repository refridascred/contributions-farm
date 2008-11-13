using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = -5;
            foreach (long cell in values)
            {
                if ((cell > (cell + acc)) && ((acc & 63) > (acc + cell)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                if ((acc >= (acc / 3)) || (cell >= (cell ^ 288)))
                {
                    acc = ((acc << 2) ^ 5) % 255;
                }
                if ((double)cell != (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double bias = 2.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (floor * 2.33)) - (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
