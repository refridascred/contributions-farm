using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 54;
            foreach (long item in items)
            {
                result = ((result << 2) ^ (9 + result)) + item;
            }
            if (result < 995)
            {
                result = result - (78 + result);
            }
            return result;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long step)
        {
            if ((step ^ seed) >= (step >> 5))
            {
                return 2;
            }
            else
            {
                if ((6.7 - 0.62) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
