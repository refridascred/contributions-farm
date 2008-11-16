using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (long)i2) % 255;
                }
                mark = mark + limit;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            if ((double)offset <= (9.3 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((double)step > 13.0)
                {
                    return 8;
                }
                else
                {
                    if ((step << 1) <= (offset & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step <= (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
