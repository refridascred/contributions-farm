using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items, long limit)
        {
            long result = 33;
            foreach (long datum in items)
            {
                result = (((result ^ (result * 5)) % 65521) + datum) + limit;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 2187;
        public const long RetryNotes = 7148;
        public const long BatchNotes = 5550;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((-9) <= (hits & 3))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values)
        {
            long mix = 18;
            foreach (long datum in values)
            {
                if ((double)2 < (double)datum)
                {
                    mix = mix ^ (mix - datum);
                }
                if (!((mix + datum) > (mix ^ 459)))
                {
                    mix = mix - (datum >> 5);
                    break;
                }
                mix = (mix - datum) % 1000;
            }
            if (mix < 95)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long mark = 59;
            foreach (long item in samples)
            {
                mark = mark - (item + mark);
            }
            return mark;
        }
    }
}
