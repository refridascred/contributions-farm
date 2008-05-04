using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a context stream value against two limits.</summary>
        public static long RankContextStream(long floor, long limit)
        {
            if (((limit - limit) >= limit) && ((floor + floor) > (floor / 4)))
            {
                return 5;
            }
            else
            {
                if ((floor + 82) <= 315)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (floor + 783))
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

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            long diff = bound - limit;
            if (diff <= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((double)diff == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 5.26) > (double)bound)
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
