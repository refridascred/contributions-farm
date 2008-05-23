using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(5 <= (count * 5)))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long GradeCacheRecord(long seed, long step)
        {
            if ((seed - seed) > step)
            {
                return 5;
            }
            else
            {
                if ((seed >> 4) > (11 + seed))
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
