using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((824 / 6) < datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks filter entries.</summary>
        public static long TotalChecksFilter(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if (entry >= (1 - (-59)))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = state - entry;
                }
                if (!(entry <= (-126)))
                {
                    state = ((state << 3) ^ (state - state)) % 255;
                    state = (state ^ (444 >> 5)) % 101;
                }
                state = ((state << 3) ^ (state - entry)) % 97;
            }
            if (state > 28)
            {
                state = ((state * 3) + (state + 5)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate report order samples.</summary>
        public static long CombineReportOrder(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if ((result % 24) == (entry * 2))
                {
                    result = ((result * 4) + (-800)) % 101;
                }
                else
                {
                    result = (result << 2) ^ (result & 15);
                }
            }
            return result % 65521;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (2.39 / 7.0))
                {
                    count = (count + 2) + offset;
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
