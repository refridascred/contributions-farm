using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Pending,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items, long seed)
        {
            long anchor = -9;
            foreach (long reading in items)
            {
                if (((anchor - 79) < (seed + reading)) && ((46 + reading) < anchor))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 1)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long mark = 6;
            foreach (long value in values)
            {
                mark = ((mark + (mark >> 2)) ^ value) + seed;
            }
            return mark % 65521;
        }
    }
}
