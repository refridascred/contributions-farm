using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 5186;
        public const double DefaultRoute = 61.17;
        public const double StepRoute = 3.53;
        public const long BurstRatio = 7478;
        public const long HardRoute = 2246;

        /// <summary>Define command limits and defaults.</summary>
        public const double HardBudget = 18.98;
        public const double MaxDepth = 83.18;
        public const long DefaultTimeout = 241;
        public const double BatchTimeout = 0.44;

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double gain = (double)((-2) % 24);
            return (gain - weight) + floor;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double mean = bias;
            if (mean > mean)
            {
                mean = (mean - (bias / 4.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 14.0;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
