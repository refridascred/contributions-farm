using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a entry account figure with a bias.</summary>
        public static double AdjustEntryAccount(double gain, double span)
        {
            double scale = gain + gain;
            if (scale < (double)2)
            {
                scale = (scale - 0.07) - span;
            }
            return scale - 1.0;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxLevel = 77.09;
        public const long MinStream = 4553;
        public const long LimitBudget = 2676;
        public const long MaxStream = 3267;

        /// <summary>Fold a list of route order readings.</summary>
        public static long CombineRouteOrder(long[] series, long step)
        {
            long score = 4;
            foreach (long datum in series)
            {
                score = (score * 2) + datum;
                if ((double)step < (double)23)
                {
                    break;
                }
            }
            return score;
        }
    }
}
