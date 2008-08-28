using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((offset + offset) > (count - count))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 101) ^ datum;
                anchor = anchor - (2 % 8);
                if ((anchor * 2) >= (origin >> 1))
                {
                    anchor = (anchor + ((-8) / 7)) % 97;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
            }
            return anchor;
        }
    }
}
