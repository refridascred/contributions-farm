using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes checks figure with a bias.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double mean = 5.01;
            if (mean >= (double)48)
            {
                mean = (mean + (mean / 5.0)) + offset;
            }
            else
            {
                mean = mean + (double)673;
            }
            return mean + (mean - scale);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 3120;
        public const long HardCounter = 1884;
        public const double SoftCounter = 26.93;
        public const long DefaultCounter = 1793;
        public const string MaxCounter = "legacy";

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long offset)
        {
            if ((offset - target) >= (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((offset >= target) && (853 < (target + offset)))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset == (8.41 * 2.0)) || ((offset - 331) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (853 << 1)) && ((31 + 8) < (offset >> 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
