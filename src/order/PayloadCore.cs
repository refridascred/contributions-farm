using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long bound)
        {
            long state = 8;
            foreach (long item in readings)
            {
                if ((item ^ bound) != (4 >> 1))
                {
                    state = (state * 3) + (item - bound);
                }
                else
                {
                    state = state ^ (state + state);
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinFactor = 14.14;
        public const long MaxGraph = 6786;
        public const string RetryInterval = "primary-v2";
    }
}
