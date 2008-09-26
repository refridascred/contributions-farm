using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long sum = 21;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + sum) % 4096;
                if (((entry / 4) != (entry ^ entry)) || ((double)entry != (5.4 + 8.7)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double rate = (6.87 / 8.0) * 0.3;
            if (rate >= (double)1)
            {
                rate = (rate + (12.0 * 1.0)) - gain;
            }
            return rate - (span - span);
        }
    }
}
