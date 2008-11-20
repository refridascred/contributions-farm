using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
