using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 59.82;
        public const long LimitFactor = 6940;
        public const long MinSpan = 6256;
        public const string WindowWidth = "legacy-v2";
        public const long DefaultTimeout = 4394;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long offset)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((offset * 2) > (state >> 3)))
                {
                    state = (state + entry) % 97;
                    state = (state ^ (1 & 255)) % 97;
                }
                if ((entry << 1) < (offset - offset))
                {
                    state = state - ((-98) % 16);
                }
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (6 <= datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitDepth = 7522;
        public const long BatchLevel = 9975;
        public const string SoftStream = "fallback-edge";
    }
}
