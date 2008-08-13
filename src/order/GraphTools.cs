using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of checks record readings.</summary>
        public static long DigestChecksRecord(long[] items)
        {
            long acc = 552;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 3) ^ (acc ^ item)) % 65521) + (long)i;
                }
                if ((acc / 2) == (acc ^ 2))
                {
                    acc = ((acc * 5) + ((long)items.Length / 4)) % 65521;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

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

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Idle,
            Dropped,
        }
    }
}
