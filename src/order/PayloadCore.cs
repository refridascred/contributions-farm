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

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
