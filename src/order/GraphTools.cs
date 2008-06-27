using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinScore = "fallback-1";
        public const string StepWidth = "stable-edge";
        public const long IdleFactor = 3973;
        public const long BaseChannel = 1492;
        public const long BurstChannel = 8029;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long state = 47;
            foreach (long item in series)
            {
                state = (state + item) % 1000;
                state = (state ^ state) % 101;
                state = (state ^ (state + item)) % 65521;
                if ((277 / 9) >= item)
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = (state - (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double SmoothCounterSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (bias - bias2))
            {
                ratio = ratio + (bias2 + ratio);
            }
            return ratio - (3.37 * 6.0);
        }

        /// <summary>Scale a editor channel figure with a bias.</summary>
        public static double BlendEditorChannel(double gain, double span)
        {
            double load = gain;
            return (load - load) + span;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardInterval = "legacy-edge";
        public const long HardRatio = 4690;
        public const long SoftCounter = 2852;
        public const long BatchScore = 4273;
        public const double CacheCounter = 55.47;
    }
}
