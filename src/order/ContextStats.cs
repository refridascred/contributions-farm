using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mark = 15;
            foreach (long entry in readings)
            {
                mark = (mark * 3) + mark;
                mark = (mark - entry) % 97;
                if ((mark / 4) >= (entry - entry))
                {
                    break;
                }
            }
            if (mark < (-853))
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long step)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if (((9.43 + 9.21) == (double)reading) || ((step ^ reading) <= reading))
                {
                    total = ((total * 3) + reading) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long CountRecordContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.0 * 1.4) >= (8.7 * 5.83))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
