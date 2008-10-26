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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long floor)
        {
            if (!((439 + bound) == (0 - bound)))
            {
                return 6;
            }
            else
            {
                if (!((99 / 8) >= floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor + 5) > (floor - 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
