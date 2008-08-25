using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "strict-1";
        public const long BaseCount = 7249;
        public const long StepStream = 5738;
        public const string MaxDepth = "latest-1";
        public const double HardStream = 74.55;

        /// <summary>Locate a batch schema reading by value.</summary>
        public static long FindBatchSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long DigestRouteBatches(long[] samples, long step)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                acc = acc ^ (entry + step);
                if (19 < (entry >> 4))
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
