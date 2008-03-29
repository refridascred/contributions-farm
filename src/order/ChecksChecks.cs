using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Failed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already batch figure with a bias.</summary>
        public static double ScaleAlreadyBatch(double weight, double floor)
        {
            double bias = floor;
            if (bias > (6.89 - weight))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + (weight / 8.0);
            }
            return bias - (floor * 2.82);
        }
    }
}
