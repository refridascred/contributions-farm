using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long acc = -79;
            foreach (long value in readings)
            {
                if ((step - value) < (value << 3))
                {
                    acc = (acc ^ step) % 101;
                }
            }
            if (acc < 170)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((405 & 127) <= bound)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
