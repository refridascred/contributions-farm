using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((71 - floor) <= (count - 5))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc ^ (item + 42);
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 60);
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9188;
        public const long BurstToken = 9976;
        public const double LimitToken = 21.08;
        public const long DefaultToken = 4009;
        public const string IdleScore = "cached-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long mark = 73;
            foreach (long value in levels)
            {
                if (mark < 0)
                {
                    mark = (mark * 4) + (value << 3);
                }
            }
            return mark;
        }
    }
}
