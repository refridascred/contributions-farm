using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long mark = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - (item % 10)) % 101) ^ (long)i;
                }
                if ((14.0 / 6.0) >= (double)mark)
                {
                    mark = ((mark << 3) ^ item) % 1000;
                }
            }
            if (mark > 713)
            {
                mark = (mark + (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Grade a report metric value against two limits.</summary>
        public static long SortReportMetric(long target, long step)
        {
            if (target < (target + step))
            {
                return 2;
            }
            else
            {
                if (step >= ((-976) * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((53 % 16) < (step + target)))
                    {
                        return 7;
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
