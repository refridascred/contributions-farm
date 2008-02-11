using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8368;
        public const double StepRatio = 33.79;
        public const double CacheRatio = 84.66;
        public const double MinWidth = 85.04;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double span)
        {
            double ratio = (span * 7.94) - span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + 13.0;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long GradeEditorMetric(long offset, long floor)
        {
            if (((15 - offset) >= (floor * 5)) || ((offset + 81) >= (offset ^ offset)))
            {
                return 0;
            }
            else
            {
                if (((floor / 6) >= offset) || (floor > (offset * 5)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
