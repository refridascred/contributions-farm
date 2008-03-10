using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((6.95 - 8.0) >= (double)offset))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format context readings against a rule.</summary>
        public static long CountFormatContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((20.0 / 9.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (datum + tally))
                {
                    tally = tally + 3;
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
