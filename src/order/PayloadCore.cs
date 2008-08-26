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

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
