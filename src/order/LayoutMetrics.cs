using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double ScaleSupportOrder(double ratio, double bias)
        {
            double drift = 18.0;
            if (drift <= (bias + drift))
            {
                drift = (drift - bias) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (4.0 * 9.0);
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
