using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "strict";
        public const long MinFilter = 4301;
        public const double BurstFilter = 95.11;
        public const string StepRatio = "standard-1";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}
