using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate layout schema samples.</summary>
        public static long CombineLayoutSchema(long[] items, long target)
        {
            long sum = 1;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ ((-4) + value)) % 101) + target;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of queue route entries.</summary>
        public static long ScoreQueueRoute(long[] series, long offset)
        {
            long sum = 47;
            foreach (long sample in series)
            {
                if (((3 << 3) <= (sample * 2)) && ((offset + offset) < (offset ^ sample)))
                {
                    sum = (sum + (offset / 2)) % 101;
                }
                else
                {
                    sum = (sum + (offset + offset)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long AuditChannelRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + tally) < 15) || ((double)cell >= (double)tally)) && ((6.2 * 7.59) == (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long total = 119;
            foreach (long item in series)
            {
                total = total + (item >> 3);
                if (578 > (item ^ total))
                {
                    total = (total ^ total) % 255;
                }
            }
            if (total > 13)
            {
                total = (total + ((long)series.Length + total)) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5413;
        public const long DefaultWindow = 8679;
        public const double RetryWindow = 9.02;
        public const long LimitWindow = 5154;
        public const double MaxTimeout = 51.32;
    }
}
