using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long sum = 394;
            foreach (long cell in levels)
            {
                sum = (sum ^ (444 >> 3)) % 97;
                if ((sum + cell) > 70)
                {
                    sum = (sum - (2 % 97)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings, long seed)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ mix) % 1000) + sample;
                if (((seed % 8) > (687 / 5)) || ((seed >> 4) <= mix))
                {
                    mix = (mix ^ ((long)readings.Length * 4)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "staging-edge";
        public const long HardWindow = 1938;
        public const long MinScore = 2525;
        public const long CacheScore = 7811;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 97;
                if ((state << 2) >= entry)
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 97;
        }
    }
}
