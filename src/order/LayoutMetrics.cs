using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long target)
        {
            long bound = offset + target;
            if ((bound - offset) >= 948)
            {
                return 6;
            }
            else
            {
                if ((8.1 - 2.4) >= (double)65)
                {
                    return 0;
                }
                else
                {
                    if (!((target - bound) != (98 % 16)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long AuditBatchesRouteMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (limit >= count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
