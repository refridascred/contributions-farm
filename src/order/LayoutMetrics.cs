using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = ratio;
            if (weight <= weight)
            {
                weight = weight - 12.0;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + (weight - bias);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long bound)
        {
            long acc = 386;
            foreach (long reading in levels)
            {
                acc = acc + (bound << 3);
                if (((20.0 + 6.3) < (double)reading) && ((double)acc < 3.3))
                {
                    acc = (acc - (bound ^ bound)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
