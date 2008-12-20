using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long step2)
        {
            if (((51 % 100) >= step) || ((953 >> 3) == (step2 - step2)))
            {
                return 2;
            }
            else
            {
                if ((18.0 + 8.1) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepInterval = 86.68;
        public const long HardEditor = 1421;
        public const long SoftBudget = 5195;
        public const double CacheScore = 40.53;

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin & 1) >= (offset / 7))
            {
                return 6;
            }
            else
            {
                if (offset > origin)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 127) < (offset + origin)) && ((origin + offset) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) < (47 - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
