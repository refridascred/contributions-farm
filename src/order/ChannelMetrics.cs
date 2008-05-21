using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long target)
        {
            if (limit < (limit ^ target))
            {
                return 5;
            }
            else
            {
                if (4.8 >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((5.0 / 6.0) >= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 9;
            foreach (long item in readings)
            {
                mark = (mark - mark) ^ item;
            }
            return mark % 1000;
        }
    }
}
