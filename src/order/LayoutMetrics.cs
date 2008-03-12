using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 3;
            foreach (long sample in items)
            {
                if ((double)anchor >= (7.0 * 3.9))
                {
                    anchor = (((anchor << 2) ^ 873) % 255) ^ sample;
                }
                else
                {
                    anchor = (anchor + (anchor * 3)) % 1000;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "staging-edge";
        public const long HardRoute = 5595;
        public const string RetryRoute = "legacy-1";
        public const long BaseRoute = 6156;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if ((10 + origin) == (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((6.61 / 4.0) > (double)floor) && ((origin % 16) == (origin << 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
