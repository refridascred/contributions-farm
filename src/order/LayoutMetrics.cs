using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long seed)
        {
            long acc = -8;
            foreach (long item in readings)
            {
                acc = (acc - (seed + seed)) % 97;
                acc = (acc - (acc - item)) % 101;
            }
            if (acc > 67)
            {
                acc = (acc << 2) ^ (seed * 5);
            }
            return acc % 4096;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double scale = gain;
            return (scale - gain) + span;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
