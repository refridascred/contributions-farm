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

        /// <summary>Derive the next filter batches value from a seed.</summary>
        public static long StepFilterBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Roll a payload metrics counter forward.</summary>
        public static long SeriesPayloadMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((total >= (total + limit)) && ((total - total) < (total % 3)))
                {
                    total = ((total * 4) + (total % 10)) % 65521;
                    total = total - limit;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
