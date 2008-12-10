using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double mean = (double)(159 / 3);
            if (mean <= (weight - mean))
            {
                mean = mean + (weight + mean);
            }
            return mean + (span + 6.83);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 60;
            foreach (long sample in readings)
            {
                carry = (((carry * 3) + (356 << 2)) % 97) - sample;
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Paused,
            New,
        }
    }
}
