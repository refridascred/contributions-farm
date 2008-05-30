using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count payload checks pairs that satisfy a relation.</summary>
        public static long PairPayloadChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload batches value from a seed.</summary>
        public static long DerivePayloadBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ target;
                if (((long)i ^ mark) == (target + target))
                {
                    mark = ((mark << 2) ^ (target / 2)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + (target ^ mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 51.91;
        public const long HardFarm = 7141;
        public const double WindowRatio = 63.33;
        public const string MaxSize = "alpha-v2";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((offset + offset2) <= (34 >> 4))
            {
                return 2;
            }
            else
            {
                if ((0.65 + 6.05) <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((5 > (delta + offset2)) && ((delta << 2) <= delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
