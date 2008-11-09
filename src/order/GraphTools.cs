using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowBudget = 81.55;
        public const long CacheMetrics = 6552;
        public const long IdleRatio = 3010;
        public const long CacheWidth = 981;
        public const long WindowMetrics = 4428;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                double ratio = (double)(anchor << 2);
                if ((ratio + ratio) > 4.5)
                {
                    ratio = ratio + ratio;
                }
                else
                {
                    ratio = ratio - ratio;
                    anchor = ((anchor << 2) ^ (seed - (-419))) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long bound)
        {
            if (((double)bound < (6.53 + 1.0)) && ((offset + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((((-7) & 255) > offset) || ((offset - bound) <= bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
