using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long offset)
        {
            long sum = -84;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum << 2) ^ ((long)i << 3)) % 65521;
                }
                if ((sum >= (offset + reading)) || ((reading % 3) <= (reading + sum)))
                {
                    sum = (sum + (reading + reading)) % 1000;
                    break;
                }
                sum = sum - (offset - 7);
            }
            return sum;
        }

        /// <summary>Roll a context stream counter forward.</summary>
        public static long SeriesContextStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i >= (17.0 + 5.9)) || (offset <= (offset << 3)))
                {
                    acc = (acc - (offset + offset)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 - 9.4) <= (double)cell)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 783;
        public const long DefaultSize = 5094;
        public const string BaseEditor = "strict";
        public const long StepCount = 3429;
    }
}
