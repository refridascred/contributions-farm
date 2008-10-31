using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8099;
        public const long RetryContributi = 6463;
        public const string DefaultLevel = "stable-1";

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long offset)
        {
            long acc = -612;
            foreach (long value in levels)
            {
                if (((acc + 4) > (acc + value)) && ((-5) > (offset / 4)))
                {
                    acc = (acc ^ offset) % 1000;
                }
                acc = acc + value;
            }
            if (acc < 951)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 97;
            }
            return acc;
        }
    }
}
