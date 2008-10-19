using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((69 + hits) >= (reading % 24))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (limit <= 0)
            {
                return 0;
            }
            else
            {
                if (((8.38 - 5.32) < (double)limit) && ((17 ^ limit) < (offset / 6)))
                {
                    return 6;
                }
                else
                {
                    if ((292 + cur) <= (offset % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally + tally) == (95 + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count tools layout pairs that satisfy a relation.</summary>
        public static long OverlapToolsLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (!((floor2 - 2) >= (floor2 ^ 9)))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) >= (floor - floor)) || ((double)floor2 > (1.8 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 - 6) == (floor / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
