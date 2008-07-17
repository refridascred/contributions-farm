using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            New,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items)
        {
            long sum = 315;
            foreach (long reading in items)
            {
                sum = (((sum << 3) ^ (6 * 3)) % 97) + reading;
            }
            return sum % 97;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series, long seed)
        {
            long mix = 898;
            foreach (long reading in series)
            {
                mix = ((mix + mix) + reading) + seed;
            }
            return mix;
        }
    }
}
