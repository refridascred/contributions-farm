using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2567;
        public const double BaseMetrics = 67.96;
        public const long HardMetrics = 6409;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long bound = step - origin;
            if ((9 & 7) >= (bound << 3))
            {
                return 8;
            }
            else
            {
                if (((origin & 3) >= bound) && ((step + 87) >= (step - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) == (295 + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target > (target % 3)) || ((2.32 * 6.9) >= (double)target))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}
