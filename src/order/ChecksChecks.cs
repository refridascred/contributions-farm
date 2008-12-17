using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double weight = scale;
            if (weight < (scale + offset))
            {
                weight = weight - (weight + weight);
            }
            return weight - (scale / 2.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long state = 31;
            foreach (long reading in samples)
            {
                if (target > (state + 3))
                {
                    state = (state - target) ^ reading;
                }
                if ((double)state > 16.0)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
