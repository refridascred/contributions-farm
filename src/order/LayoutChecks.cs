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

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long target2)
        {
            long gap = target + target2;
            if (((8.6 * 1.89) <= (double)gap) || ((38 + gap) >= (target2 + target2)))
            {
                return 0;
            }
            else
            {
                if (target2 > (gap / 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
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
