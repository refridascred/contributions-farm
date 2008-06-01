using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
