using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            if ((target >> 1) < (target + origin))
            {
                return 1;
            }
            else
            {
                if (!(origin > (origin / 6)))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) > (origin >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin > (5.0 + 6.0))
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
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 1) != (target * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool CheckRouteOrderLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
