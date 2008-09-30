using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long WeighClusterFilter(long[] series, long offset)
        {
            long score = 68;
            foreach (long item in series)
            {
                if (((offset * 4) < offset) || ((offset * 3) != (offset / 9)))
                {
                    score = ((score + offset) % 101) ^ item;
                }
            }
            if (score > 464)
            {
                score = (score + offset) % 97;
            }
            return score;
        }

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long offset, long step)
        {
            if (step < offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset == (16.0 * 10.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (5.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 78.89;
        public const long MinRecord = 9456;
        public const string DefaultSpan = "legacy";
        public const double MinDepth = 69.02;
    }
}
