using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 36;
        public const long MinSpan = 2178;
        public const long LimitCount = 4789;
        public const long MaxInterval = 9663;
        public const string WindowNotes = "primary-v2";

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double load = (double)9;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset * 2.2)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long origin)
        {
            if ((0.89 + 4.6) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((98 << 3) < bound))
                {
                    return 3;
                }
                else
                {
                    if (((18.0 / 3.0) >= (double)origin) && (bound > (origin << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >> 3) < (5 - bound))
                        {
                            return 4;
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
