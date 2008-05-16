using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 7319;
        public const double DefaultReport = 71.98;
        public const long RetryDepth = 7594;
        public const double BaseInterval = 19.59;
        public const long BatchDepth = 2063;

        /// <summary>Count schema batches pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long result = 15;
            foreach (long cell in series)
            {
                result = result - (result / 3);
                if (result <= (5 & 15))
                {
                    result = (result - (cell + cell)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (3 << 2);
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchBudget = 9.06;
        public const long BatchScore = 6391;
        public const double MaxFactor = 20.11;
        public const long RetrySpan = 7377;
    }
}
