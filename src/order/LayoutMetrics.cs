using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepBudget = "cached";
        public const string LimitFarm = "primary-1";
        public const long StepFarm = 8815;
        public const long BatchFarm = 5825;

        /// <summary>Grade a graph layout value against two limits.</summary>
        public static long RankGraphLayout(long offset, long limit)
        {
            long gap = offset ^ limit;
            if ((double)limit < (4.77 * 1.71))
            {
                return 2;
            }
            else
            {
                if ((gap - gap) >= offset)
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit >= (double)gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset + gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
