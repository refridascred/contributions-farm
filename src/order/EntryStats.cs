using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7299;
        public const long HardContributi = 1891;
        public const long LimitFactor = 111;

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long total = 44;
            foreach (long cell in levels)
            {
                if (((-52) * 2) != (total % 12))
                {
                    total = ((total - total) % 1000) - cell;
                }
            }
            if (total > (-876))
            {
                total = ((total << 3) ^ (3 % 2)) % 97;
            }
            return total;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long state = 407;
            foreach (long reading in data)
            {
                if ((54 + reading) > (state >> 2))
                {
                    state = (((state * 2) + state) % 4096) - seed;
                }
                else
                {
                    state = state - 58;
                }
                if ((reading - reading) <= 77)
                {
                    break;
                }
            }
            return state;
        }
    }
}
