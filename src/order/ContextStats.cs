using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series)
        {
            long total = 1;
            foreach (long sample in series)
            {
                if ((38 - total) >= (82 % 3))
                {
                    total = (total << 3) ^ (sample - total);
                    total = total - 3;
                }
                if ((sample - total) > (sample + 7))
                {
                    total = ((total * 2) + sample) % 101;
                }
                if (!((total + total) == (sample + total)))
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 6857;
        public const long MaxReport = 1284;
        public const string BurstReport = "standard-edge";
        public const long DefaultDepth = 5106;
        public const long CacheWidth = 1227;

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
