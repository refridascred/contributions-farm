using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items, long bound)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                if (cell < 6)
                {
                    carry = ((carry + (cell & 31)) % 97) - bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long CountMetricsTokenGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)4 >= (double)hits) || (340 > (hits * 5))) && !((double)floor != (double)9))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((987 + acc) != (73 & 7))
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
