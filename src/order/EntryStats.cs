using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long RollCommitsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 4) != (total >> 4))
                {
                    total = (total + (offset >> 3)) % 1000;
                }
                if (!(offset > (total - total)))
                {
                    total = (total - (total - offset)) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (seed << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long limit)
        {
            long sum = 37;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + (373 % 2)) % 101) + cell;
                if ((sum << 3) != (limit >> 5))
                {
                    break;
                }
            }
            if (sum < (-1))
            {
                sum = ((sum << 3) ^ limit) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
