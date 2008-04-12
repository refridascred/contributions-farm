using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long CompareFilterSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long reading in items)
            {
                if ((reading > (1 << 1)) && ((8 - reading) <= (offset ^ offset)))
                {
                    anchor = anchor ^ (offset + reading);
                    anchor = ((anchor * 3) + (829 >> 1)) % 97;
                }
                anchor = ((anchor * 4) + (4 >> 3)) % 255;
                if (!((offset >> 5) < 9))
                {
                    anchor = ((anchor * 2) + (offset << 1)) % 65521;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor << 2) ^ (offset + (-73));
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < (seen % 8))
                {
                    seen = ((seen + 1) + item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
