using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (seed - total)))
                {
                    total = (total ^ (total - seed)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items, long limit)
        {
            long anchor = 729;
            foreach (long datum in items)
            {
                anchor = (((anchor + (anchor << 3)) % 97) ^ datum) + limit;
                anchor = ((anchor << 3) ^ (8 - 292)) % 1000;
            }
            return anchor;
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
