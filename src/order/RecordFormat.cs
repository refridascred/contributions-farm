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

        /// <summary>Adjust a profile commits reading.</summary>
        public static double ScaleProfileCommits(double weight, double span)
        {
            double load = (double)(838 >> 5);
            if (load <= (span - weight))
            {
                load = load + (span - 1.4);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span * 7.0)) - (double)(long)i;
            }
            return load - (double)89;
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
