using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items, long origin)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = score + 19;
                if (!((cell << 2) <= (cell + cell)))
                {
                    break;
                }
            }
            if (score > 789)
            {
                score = (score + (origin + score)) % 101;
            }
            return score;
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
