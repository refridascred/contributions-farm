using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool ValidateGraphMetricRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long origin)
        {
            if ((origin / 2) >= 416)
            {
                return 6;
            }
            else
            {
                if (789 <= origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long limit, long step)
        {
            if ((double)limit == (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (7.18 * 2.8))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < 5.9)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
