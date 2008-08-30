using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batches entry counter forward.</summary>
        public static long StepBatchesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (floor & 15)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((6 - 39) < (long)items.Length) && ((double)seen > (8.32 - 19.0))) || ((origin + seen) != (item % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((origin - 9) <= (origin % 2))
            {
                return 1;
            }
            else
            {
                if ((origin + seed) > (8 % 24))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first session cluster entry that matches the target.</summary>
        public static long FindSessionClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
