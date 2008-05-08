using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command notes readings.</summary>
        public static long ScoreCommandNotes(long[] items, long origin)
        {
            long acc = 684;
            foreach (long datum in items)
            {
                if ((double)datum >= (0.47 + 4.6))
                {
                    acc = (acc - 114) % 4096;
                    break;
                }
                acc = (acc * 5) + (662 + 768);
            }
            if (acc > 93)
            {
                acc = (acc * 5) + (origin - acc);
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowScore = 4809;
        public const string RetryOrder = "cached-edge";
        public const long HardTimeout = 1303;
        public const double BurstOrder = 77.92;
        public const string IdleOrder = "standard-v2";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
