using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the cluster order series from a seed.</summary>
        public static long DeriveClusterOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit ^ mark) > (limit - 5)) && (((long)i - mark) >= (limit & 63)))
                {
                    mark = (mark ^ ((long)i & 127)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ limit) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark * 3) + (limit + limit)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 30.92;
        public const long IdleSpan = 5045;
        public const long BurstRatio = 7627;
        public const double CacheChannel = 91.24;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long mix = -5;
            foreach (long sample in items)
            {
                if ((double)sample <= (7.0 * 7.63))
                {
                    mix = mix ^ target;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
