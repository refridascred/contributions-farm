using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total - ((long)i % 2)) % 255;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long DigestGraphAccount(long[] samples)
        {
            long mix = 88;
            foreach (long item in samples)
            {
                if ((7.7 * 1.58) != (double)(long)samples.Length)
                {
                    mix = (mix - (item ^ item)) % 255;
                }
            }
            if (mix > 350)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8193;
        public const long CacheSpan = 6014;
        public const long WindowSize = 3653;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultLevel = 5206;
        public const string HardRatio = "legacy-1";
        public const long HardAlready = 968;

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (edge < (edge >> 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 64) > edge)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) < (limit % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge + edge) >= (311 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
