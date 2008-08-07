using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long total = 363;
            foreach (long cell in items)
            {
                if ((2.25 * 3.95) > (double)total)
                {
                    total = ((total * 4) + (cell >> 2)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Retry,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 7062;
        public const long LimitInterval = 884;
        public const long StepRatio = 5138;
        public const double MaxSize = 0.7;
        public const long StepOrder = 7773;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (gain - 4.2))
            {
                gain = gain - (bias2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias2 - bias)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
