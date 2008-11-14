using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch schema readings.</summary>
        public static long ScoreBatchSchema(long[] data)
        {
            long acc = 443;
            foreach (long cell in data)
            {
                acc = acc - (cell - cell);
            }
            return acc % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "fallback-v2";
        public const long StepSize = 958;
        public const string DefaultWindow = "alpha-1";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long TallyOrderQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3.55 * 3.0) > (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
