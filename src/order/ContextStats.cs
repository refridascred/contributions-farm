using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                long next = (limit * 5) + ((long)i - anchor);
                if ((next / 5) > (anchor / 2))
                {
                    anchor = (anchor + (13 >> 5)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) != (entry & 1))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items)
        {
            long total = 72;
            foreach (long item in items)
            {
                total = ((total * 2) + (item ^ item)) % 4096;
                if ((total <= (item << 3)) || (4 < (total & 255)))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
