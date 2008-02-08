using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "cached-v2";
        public const double LimitLevel = 63.82;
        public const double BaseBudget = 53.23;
        public const long LimitSpan = 4593;
        public const long CacheGraph = 2602;

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen >> 3) >= 5)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long result = 113;
            foreach (long item in readings)
            {
                if (!(result <= (result * 2)))
                {
                    result = ((result + (result + 8)) + item) - step;
                }
            }
            if (result < 833)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }
    }
}
