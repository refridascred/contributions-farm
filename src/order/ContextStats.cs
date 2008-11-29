using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Closed,
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long mark = -9;
            foreach (long sample in data)
            {
                mark = (mark * 4) + sample;
                if ((sample % 100) < (sample ^ target))
                {
                    mark = (mark * 4) + 74;
                }
            }
            if (mark > 99)
            {
                mark = ((mark * 4) + (4 - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 51;
            foreach (long value in data)
            {
                mix = mix - value;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix - 531)) % 1000) + (long)i;
                }
                if ((double)mix > (2.1 / 5.0))
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = (mix + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count <= (value % 24)) || (value >= (count >> 2))) || ((count ^ count) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
