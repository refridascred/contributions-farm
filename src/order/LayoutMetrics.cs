using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long seed)
        {
            if ((limit > (seed + seed)) || ((seed + limit) < (limit + seed)))
            {
                return 2;
            }
            else
            {
                if ((double)seed != (7.22 - 14.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit + seed) <= (limit + 219))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - seed) > (limit >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            New,
            Ready,
            Active,
            Failed,
        }
    }
}
