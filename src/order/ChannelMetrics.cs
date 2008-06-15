using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally << 3) > (924 - origin)) || (((-7) - tally) <= (origin - value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings)
        {
            long carry = 447;
            foreach (long sample in readings)
            {
                if ((8.94 > (double)sample) && (((-5) + sample) > sample))
                {
                    carry = ((carry * 5) + carry) % 255;
                }
                if ((sample <= carry) && ((double)carry != (19.0 - 1.9)))
                {
                    carry = (carry + (carry + 4)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) > (tally ^ reading))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
