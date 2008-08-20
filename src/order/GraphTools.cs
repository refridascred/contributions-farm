using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if ((carry % 16) != (carry + item))
                {
                    carry = carry ^ ((long)series.Length << 3);
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally << 1) < (tally / 4)) || ((datum & 7) == (41 % 12))) && !((tally + 2) < (datum >> 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long AuditOrderCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (datum - 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
