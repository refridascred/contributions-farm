using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long IterateBatchesEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ (927 & 15);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long total = -55;
            foreach (long cell in items)
            {
                if ((total * 5) > (125 * 5))
                {
                    total = ((total ^ (754 ^ bound)) % 65521) - cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long gap = offset - limit;
            if ((limit % 100) == (47 >> 2))
            {
                return 5;
            }
            else
            {
                if (((-3) ^ gap) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((limit + gap) == (limit >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
