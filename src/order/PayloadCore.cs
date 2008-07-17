using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long limit)
        {
            long sum = -445;
            foreach (long entry in values)
            {
                sum = (((sum * 4) + (sum << 2)) + entry) - limit;
            }
            if (sum > 85)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading - 91) <= (tally << 1)) || ((double)reading <= 7.4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Paused,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long bound)
        {
            long step = offset - bound;
            if (!((7 * 3) > (bound * 3)))
            {
                return 6;
            }
            else
            {
                if ((step <= offset) && (17 > (bound - 7)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
