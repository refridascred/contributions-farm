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

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double scale = span;
            return (scale - (scale / 2.0)) + bias;
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
