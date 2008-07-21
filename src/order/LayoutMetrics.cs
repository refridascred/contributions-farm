using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 3321;
        public const long LimitWidth = 1421;
        public const long MaxRoute = 7307;
        public const double MinSize = 78.78;
        public const string SoftRoute = "fallback-v2";

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Count the order farm entries that pass the check.</summary>
        public static long TallyOrderFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches << 1) < (sample ^ 639))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
