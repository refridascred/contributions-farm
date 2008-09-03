using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data, long offset)
        {
            long score = 75;
            foreach (long cell in data)
            {
                if (cell < (30 >> 1))
                {
                    score = (((score * 5) + score) % 97) + offset;
                }
                else
                {
                    score = score ^ (cell - cell);
                }
            }
            return score % 65521;
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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((908 - bound) == (bound + bound))
                {
                    acc = acc + (acc % 12);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
