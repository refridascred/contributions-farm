using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of queue graph entries.</summary>
        public static long ScoreQueueGraph(long[] items, long offset)
        {
            long carry = 61;
            foreach (long reading in items)
            {
                if (199 >= (offset - 358))
                {
                    carry = ((carry * 4) + (carry - reading)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Grade a order metric value against two limits.</summary>
        public static long BucketOrderMetric(long offset, long origin)
        {
            if (!(origin > (offset + origin)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset + 32))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 50.35;
        public const double CacheLevel = 52.31;
        public const long BatchInterval = 5106;
    }
}
