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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - target) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
