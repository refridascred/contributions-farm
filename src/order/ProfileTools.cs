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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6730;
        public const long BatchChannel = 8309;
        public const long CacheChannel = 5193;
        public const long BurstLevel = 1379;
        public const double IdleChannel = 7.86;

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
