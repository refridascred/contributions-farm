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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
