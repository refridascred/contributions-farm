using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2994;
        public const string RetryStream = "open-v2";
        public const long HardInterval = 6723;
        public const long MinFactor = 8600;
        public const long HardTimeout = 2412;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (gain * 9.47)) + (double)(long)i) + rate;
            }
            return gain + (double)8;
        }

        /// <summary>Measure how many support commits samples are out of range.</summary>
        public static long CountSupportCommitsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits / 2) < hits) && (((hits % 12) <= (step ^ sample)) && ((hits >> 1) == (hits / 8))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((5 - cur) < (offset ^ (-29)))
            {
                return 2;
            }
            else
            {
                if ((double)offset != (8.72 + 2.15))
                {
                    return 7;
                }
                else
                {
                    if ((cur / 4) >= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool VerifySessionEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
