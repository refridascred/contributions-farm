using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if ((double)total != (3.5 / 4.0))
                {
                    total = (total * 2) + (entry - total);
                }
            }
            return total;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long bound)
        {
            long gap = offset + bound;
            if ((5.0 * 8.9) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset / 2)))
                {
                    return 4;
                }
                else
                {
                    if (3.4 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap << 1) >= bound) && ((47 / 8) <= (gap ^ 6)))
                        {
                            return 2;
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
}
