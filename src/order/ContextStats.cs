using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long ClassifyChannelTools(long step, long floor)
        {
            if ((step / 5) == (885 * 3))
            {
                return 6;
            }
            else
            {
                if ((0.1 * 8.0) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool ValidatePayloadRouteRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi editor readings.</summary>
        public static long TotalContributiEditor(long[] samples, long limit)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                result = (result * 4) + (756 & 7);
                if ((double)reading > 8.0)
                {
                    result = (result ^ reading) % 4096;
                }
                if ((reading ^ limit) == (reading & 31))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the format filter entries that pass the check.</summary>
        public static long AuditFormatFilterMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen > 171)
                {
                    seen = ((seen + 1) ^ datum) - origin;
                }
            }
            return seen;
        }
    }
}
