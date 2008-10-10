using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheInterval = 18.46;
        public const string SoftLevel = "legacy-edge";
        public const long BatchContext = 9200;
        public const double HardContext = 98.42;

        /// <summary>Count buffer format pairs that satisfy a relation.</summary>
        public static long OverlapBufferFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session metrics counter forward.</summary>
        public static long RollSessionMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + ((long)i & 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry - 78) ^ reading) - seed;
                carry = (carry - 252) % 97;
            }
            return carry % 65521;
        }
    }
}
