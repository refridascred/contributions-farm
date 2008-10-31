using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-12) & 31) <= ((long)data.Length + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
