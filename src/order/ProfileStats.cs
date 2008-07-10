using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry + entry)) % 4096;
            }
            if (state > 879)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples)
        {
            long acc = -5;
            foreach (long value in samples)
            {
                if ((acc - value) != (acc + value))
                {
                    acc = ((acc * 2) + 5) % 4096;
                }
                if ((1.0 * 7.56) <= (double)acc)
                {
                    acc = (acc - value) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "open-1";
        public const long SoftSpan = 5308;
        public const long LimitTimeout = 6716;
        public const string MinBudget = "cached-1";

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
