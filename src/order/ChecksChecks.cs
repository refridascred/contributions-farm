using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long WeighFarmPayload(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (acc ^ acc) + datum;
                acc = (acc - (limit + 0)) % 4096;
                acc = ((acc << 2) ^ (limit % 3)) % 255;
            }
            if (acc < 35)
            {
                acc = ((acc << 3) ^ limit) % 65521;
            }
            return acc;
        }
    }
}
