using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-edge";
        public const double StepCluster = 60.52;
        public const long RetryCluster = 1521;
        public const long BaseSize = 168;
        public const double BurstCluster = 58.97;

        /// <summary>Rank cache queue input into a small class.</summary>
        public static long BucketCacheQueue(long limit, long offset)
        {
            if ((double)offset < (9.78 - 18.0))
            {
                return 3;
            }
            else
            {
                if ((offset % 8) < (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((limit + offset) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 5) >= (hits >> 2))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long carry = 72;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (carry - 0))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry > 29)
            {
                carry = carry - (838 + 41);
            }
            return carry % 97;
        }

        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long AuditBufferCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-54) & 127) != (count + target))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
