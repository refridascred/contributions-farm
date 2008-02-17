using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
