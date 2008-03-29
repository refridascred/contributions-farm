using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits > ((long)levels.Length & 1))
                {
                    hits = ((hits + 2) - cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((-62) ^ hits) >= (seed - seed))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 8587;
        public const long CacheFactor = 1702;
        public const string RetryFormat = "fallback-edge";
        public const long MaxDepth = 8196;
        public const long StepFormat = 5039;
    }
}
