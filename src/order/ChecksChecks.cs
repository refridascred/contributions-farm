using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < floor)
            {
                ratio = ratio - (scale / 3.0);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + (floor * 4.0);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 1) < (2 << 3)) || ((4 ^ 734) <= (offset + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 7893;
        public const long StepMetrics = 2895;
        public const long StepSpan = 674;
        public const long WindowBudget = 9664;
        public const long BatchRatio = 5702;
    }
}
