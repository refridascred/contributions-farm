using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (target + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleLevel = 4880;
        public const long HardTimeout = 9366;
        public const long CacheBatch = 8150;
        public const double StepWidth = 45.93;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Combine notes payload values into a single score.</summary>
        public static long TallyNotesPayload(long[] items, long bound)
        {
            long mix = 69;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ mix) ^ value;
            }
            if (mix > 729)
            {
                mix = ((mix << 3) ^ (25 + bound)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-2) ^ count) <= (5 + 8)) && (entry > (floor / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
