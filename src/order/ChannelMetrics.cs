using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches != (8.0 / 8.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + tally) > (tally >> 5))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
