using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long ClassifyFarmBatch(long origin, long step)
        {
            long prev = origin - step;
            if ((double)step < 5.06)
            {
                return 6;
            }
            else
            {
                if ((prev - step) != (prev & 1))
                {
                    return 1;
                }
                else
                {
                    if ((step / 2) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin - 493) >= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftFactor = "stable-v2";
        public const long BurstChecks = 3037;
        public const long BatchTimeout = 476;

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values, long limit)
        {
            long sum = 413;
            foreach (long sample in values)
            {
                if ((sum + limit) > (limit % 7))
                {
                    sum = (sum - (sample + sample)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
