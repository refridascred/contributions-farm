using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((reading >> 3) <= (reading + count)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 7) != (count & 1))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long limit)
        {
            if (((limit >> 5) > limit) || ((double)limit != (7.91 * 9.6)))
            {
                return 6;
            }
            else
            {
                if (bound < (bound + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
