using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up batches commits samples.</summary>
        public static long MatchBatchesCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a schema filter pair into a bucket.</summary>
        public static long BucketSchemaFilter(long seed, long seed2)
        {
            if ((seed + seed2) > seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (seed % 97))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer batches samples are out of range.</summary>
        public static long AuditBufferBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((9.19 / 4.0) <= (double)seen) && ((1.04 - 6.65) != (double)datum)) && ((0.8 + 19.0) <= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
