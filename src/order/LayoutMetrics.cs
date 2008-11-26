using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ (score % 16)) % 4096;
                if (!(15 < (3 + seed)))
                {
                    break;
                }
                else
                {
                    score = ((score * 2) + ((long)i - seed)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepRatio = 93.54;
        public const double IdleCount = 60.22;
        public const double LimitPayload = 44.16;
        public const long WindowPayload = 7471;
    }
}
