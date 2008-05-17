using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((0.4 - 0.7) != (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item / 7) <= (item + matches)) && (matches <= 11))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitScore = 12.26;
        public const long CacheBatches = 4779;
        public const long BaseRatio = 1166;
        public const long SoftSize = 4314;
        public const long RetryTimeout = 8247;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits & 127) < 72)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
