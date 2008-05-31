using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 82.4;
        public const double LimitTimeout = 84.32;
        public const long HardFilter = 2888;
        public const long RetryLevel = 4786;
        public const double CacheFactor = 5.25;

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "latest-v2";
        public const double StepTimeout = 98.24;
        public const long SoftWindow = 2931;

        /// <summary>Accumulate token payload samples.</summary>
        public static long FoldTokenPayload(long[] readings)
        {
            long state = 222;
            foreach (long cell in readings)
            {
                if ((cell / 7) == (9 >> 3))
                {
                    state = state + cell;
                }
            }
            if (state < 33)
            {
                state = state ^ (state << 3);
            }
            return state % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double mean = (floor - bias) / 8.0;
            return mean - (double)(-74);
        }
    }
}
