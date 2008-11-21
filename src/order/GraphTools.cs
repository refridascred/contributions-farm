using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long GradeCounterBatches(long target, long origin)
        {
            if ((target + origin) >= origin)
            {
                return 3;
            }
            else
            {
                if ((570 <= target) && ((871 - target) != (target % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((1.03 * 2.5) >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + bias;
            }
            return drift - drift;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSize = "open-1";
        public const long BatchTimeout = 8754;
        public const double CacheScore = 62.03;
        public const long HardStats = 9932;
        public const long BatchStats = 1561;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
