using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1733;
        public const double BurstQueue = 89.51;
        public const double LimitWidth = 70.62;
        public const long BaseQueue = 1863;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples, long seed)
        {
            long total = -868;
            foreach (long entry in samples)
            {
                total = (total + (entry - total)) % 4096;
            }
            if (total < 94)
            {
                total = (total * 2) + (27 + seed);
            }
            return total;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit % 2) != (limit ^ state))
                {
                    state = ((state * 5) + ((long)i - state)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
