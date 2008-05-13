using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 59.54;
        public const long HardLevel = 2026;
        public const string HardAlready = "legacy-v2";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record stream readings.</summary>
        public static long DigestRecordStream(long[] values, long bound)
        {
            long acc = 90;
            foreach (long value in values)
            {
                if (((bound ^ acc) < (acc * 5)) && (16.0 < (double)acc))
                {
                    acc = ((acc << 2) ^ acc) + value;
                }
            }
            if (acc < 46)
            {
                acc = (acc + acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Match up cache entry samples.</summary>
        public static long CompareCacheEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
