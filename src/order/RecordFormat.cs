using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two editor report measurements.</summary>
        public static double BlendEditorReport(double scale, double floor)
        {
            double scale2 = scale / 8.0;
            return (scale2 + (scale - scale)) + floor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items, long origin)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = ((((acc << 2) ^ (acc / 7)) % 4096) - entry) - origin;
            }
            return acc % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally + item) >= (7 * 3)) && (4 < (long)items.Length)) && (tally < (tally ^ item)))
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
