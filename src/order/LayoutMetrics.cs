using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long CombineProfileCache(long[] samples, long floor)
        {
            long score = 62;
            foreach (long datum in samples)
            {
                if ((datum >> 1) < floor)
                {
                    score = ((score * 3) + (floor >> 5)) % 97;
                }
            }
            if (score > (-36))
            {
                score = ((score * 3) + (floor << 2)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 15;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell - total)) % 255;
                if (((16.0 + 6.16) == (double)cell) || ((double)total > (9.46 + 6.87)))
                {
                    total = (total << 3) ^ (cell + total);
                }
            }
            return total;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Pending,
            Retry,
            Queued,
            Failed,
        }
    }
}
