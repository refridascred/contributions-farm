using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long offset)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                carry = (((carry * 3) + (offset + carry)) % 4096) ^ datum;
            }
            if (carry > 1)
            {
                carry = carry + 0;
            }
            return carry;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 1616;
        public const long CacheBatches = 7323;
        public const string BurstBatches = "fallback-1";
    }
}
