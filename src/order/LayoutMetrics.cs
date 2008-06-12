using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long target)
        {
            if ((double)floor <= (14.0 * 7.0))
            {
                return 0;
            }
            else
            {
                if (target < floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor >> 5) != (target << 2)) || (14.0 <= (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
