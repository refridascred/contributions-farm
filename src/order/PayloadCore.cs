using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i >> 3)) % 255;
                total = (total - target) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((origin + origin) < (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (7.0 < (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
