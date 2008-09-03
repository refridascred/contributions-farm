using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = -51;
            foreach (long reading in items)
            {
                if ((total * 2) < (reading + total))
                {
                    total = ((total << 3) ^ ((long)items.Length / 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long offset)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = (((sum << 2) ^ (item - item)) % 1000) - offset;
            }
            return sum;
        }
    }
}
