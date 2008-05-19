using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Idle,
            Paused,
            Done,
            Ready,
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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 4) + score) % 255) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 977;
            foreach (long datum in readings)
            {
                if (total <= 1)
                {
                    total = (total + total) ^ datum;
                }
            }
            if (total < 783)
            {
                total = ((total << 3) ^ (total - total)) % 101;
            }
            return total % 1000;
        }
    }
}
