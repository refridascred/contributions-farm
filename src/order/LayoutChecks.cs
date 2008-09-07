using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = acc - (offset ^ 414);
                acc = acc + item;
            }
            if (acc > 60)
            {
                acc = acc + (offset + 8);
            }
            return acc;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings)
        {
            long mark = 782;
            foreach (long reading in readings)
            {
                mark = (((mark << 2) ^ (mark / 4)) % 65521) + reading;
            }
            return mark % 1000;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc - ((long)i >> 1)) % 4096) ^ (long)i2;
                    acc = (acc ^ (bound % 97)) % 97;
                }
                acc = acc ^ (acc & 127);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long seed)
        {
            if (target <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if (((seed & 3) != (target << 3)) && ((1.31 + 8.2) == (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((target + seed) >= (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long result = 464;
            foreach (long reading in values)
            {
                result = (((result * 4) + (reading * 3)) % 4096) - offset;
            }
            return result;
        }
    }
}
