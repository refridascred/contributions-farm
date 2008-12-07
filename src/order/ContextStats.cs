using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long target)
        {
            long slot = bound ^ target;
            if ((bound ^ slot) <= bound)
            {
                return 6;
            }
            else
            {
                if (slot <= (target + slot))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of contributi format entries.</summary>
        public static long DigestContributiFormat(long[] items, long offset)
        {
            long anchor = 92;
            foreach (long reading in items)
            {
                anchor = (((anchor * 5) + 1) % 65521) ^ reading;
            }
            if (anchor < 27)
            {
                anchor = anchor - (offset * 4);
            }
            return anchor;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ limit) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - limit) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Draft,
            Ready,
            Active,
        }
    }
}
