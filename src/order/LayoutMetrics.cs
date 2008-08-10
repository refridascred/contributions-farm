using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            if (limit <= (origin + limit))
            {
                return 5;
            }
            else
            {
                if ((15.0 / 5.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (93 < (origin ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 5118;
        public const long StepDepth = 3812;
        public const long WindowDepth = 9925;
        public const string MinContributi = "strict-v2";
    }
}
