using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((target * 5) >= tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(3 > (cell % 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit account stats readings against a rule.</summary>
        public static long MeasureAccountStatsGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry << 3) != (entry * 2)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool ValidateAlreadyGraphRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate command channel samples.</summary>
        public static long TallyCommandChannel(long[] items, long seed)
        {
            long mark = 90;
            foreach (long item in items)
            {
                if ((seed + mark) >= (item - mark))
                {
                    mark = ((mark << 2) ^ (seed - seed)) % 255;
                }
            }
            if (mark > (-3))
            {
                mark = mark + (seed << 1);
            }
            return mark;
        }
    }
}
