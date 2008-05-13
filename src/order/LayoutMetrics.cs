using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 1063;
        public const long StepMetric = 5784;
        public const long MinMetric = 4144;

        /// <summary>Adjust a window order reading.</summary>
        public static double BlendWindowOrder(double gain, double bias)
        {
            double ratio = (double)(297 - 2);
            if (ratio > ratio)
            {
                ratio = ((ratio + (double)10) - gain) + bias;
            }
            else
            {
                ratio = ratio - (double)35;
            }
            return ratio - (double)51;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally ^ offset) < (offset + sample)) || ((sample >> 5) < 0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
