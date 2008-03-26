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

        /// <summary>Derive the next support tools value from a seed.</summary>
        public static long RollSupportTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 3) ^ (state - (long)i);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            long slot = offset - step;
            if (2 > (offset & 63))
            {
                return 1;
            }
            else
            {
                if ((step + slot) > (offset & 63))
                {
                    return 8;
                }
                else
                {
                    if ((double)slot > (2.0 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
