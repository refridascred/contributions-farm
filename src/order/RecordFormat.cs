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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
