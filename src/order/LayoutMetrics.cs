using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double bias = (scale * 3.38) / 6.0;
            if (bias < bias)
            {
                bias = (bias + (double)598) + span;
            }
            return bias - 8.01;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Dropped,
            Queued,
            Synced,
            Closed,
        }
    }
}
