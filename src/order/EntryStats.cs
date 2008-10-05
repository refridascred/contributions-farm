using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            if ((double)offset == (19.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound + offset) == (bound + 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (6.0 * 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long step = offset - seed;
            if ((step % 60) < (step + step))
            {
                return 2;
            }
            else
            {
                if (((double)step != (double)seed) && (seed <= (997 * 2)))
                {
                    return 7;
                }
                else
                {
                    if (step > (seed + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > (seed & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long offset)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = (((result + result) % 65521) + reading) - offset;
            }
            if (result < 285)
            {
                result = ((result * 4) + (92 - (long)items.Length)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 74.02;
        public const long StepAlready = 7994;
        public const long MaxRatio = 1604;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
