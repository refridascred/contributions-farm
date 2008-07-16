using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Closed,
            New,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Idle,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long AuditSessionFormatMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + sample) == (count << 3)) || ((double)sample != (8.9 - 6.3)))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            if (!((double)limit < (8.88 - 5.8)))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.16 + 9.5) <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((entry >> 2) == (entry - floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command checks counter forward.</summary>
        public static long IterateCommandChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + floor) % 4096;
                if (!((anchor - anchor) >= (anchor % 12)))
                {
                    anchor = (anchor - anchor) % 97;
                    anchor = ((anchor << 3) ^ (long)i) % 97;
                }
                anchor = (anchor * 4) + (floor - floor);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
