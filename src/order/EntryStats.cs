using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long offset)
        {
            if ((bound * 3) < (offset % 64))
            {
                return 4;
            }
            else
            {
                if ((0.1 * 7.8) <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                anchor = (((anchor * 5) + origin) % 65521) ^ item;
                if ((anchor * 5) <= (origin << 1))
                {
                    anchor = anchor + (long)levels.Length;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ ((long)i << 2);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
