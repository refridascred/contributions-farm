using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 1) != (cell - (long)readings.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((double)offset <= (1.0 - 7.0))
            {
                return 4;
            }
            else
            {
                if (((4.6 * 13.0) >= (double)offset) || ((seed + seed) < (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 8.77)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
