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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if (49 < (seed / 6))
                {
                    mark = ((mark * 5) + seed) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (seed + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
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
