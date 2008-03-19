using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                long gap = (142 + (long)i) << 3;
                if (((double)(-8) == (double)gap) && ((origin ^ result) != (gap ^ gap)))
                {
                    gap = ((gap << 3) ^ (gap - 3)) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 1950;
        public const string BurstRecord = "stable";
        public const long LimitRecord = 1550;
        public const long SoftRecord = 493;
        public const double StepLevel = 93.46;

        /// <summary>Blend two entry window measurements.</summary>
        public static double AdjustEntryWindow(double rate, double bias)
        {
            double scale = rate;
            return (scale + scale) + bias;
        }
    }
}
