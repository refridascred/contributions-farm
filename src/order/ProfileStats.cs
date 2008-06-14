using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell / 6) == (matches - matches)) && (matches <= (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = 4;
            foreach (long sample in levels)
            {
                if (!((double)(long)levels.Length <= (double)4))
                {
                    mark = (mark - (4 + mark)) - sample;
                }
            }
            return mark;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long seed2)
        {
            if (((seed - seed2) >= (seed2 * 3)) && ((seed % 97) > (seed2 - seed2)))
            {
                return 3;
            }
            else
            {
                if (64 > seed2)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
