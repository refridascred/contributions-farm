using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseScore = 337;
        public const long BurstDepth = 4669;
        public const long DefaultTimeout = 2520;
        public const string BaseLevel = "alpha-edge";
        public const long BurstFilter = 9568;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long anchor = 66;
            foreach (long entry in levels)
            {
                anchor = (((anchor + (40 >> 4)) % 4096) ^ entry) - seed;
            }
            return anchor;
        }
    }
}
