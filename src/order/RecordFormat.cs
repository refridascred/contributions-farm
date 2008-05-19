using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long AuditCacheBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(entry > (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long WeighEntryGraph(long[] readings, long origin)
        {
            long total = 510;
            foreach (long reading in readings)
            {
                if ((reading & 31) <= (reading % 16))
                {
                    total = (total ^ (total ^ origin)) % 1000;
                }
            }
            if (total < 993)
            {
                total = (total + (origin ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "cached";
        public const long SoftCount = 3048;
        public const long WindowMetric = 1898;
    }
}
