using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 668;
        public const long HardFilter = 1788;
        public const double DefaultCount = 9.51;
        public const long SoftFilter = 8072;
        public const double StepInterval = 11.1;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound << 3) < (entry >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= (count % 97))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long seed)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                long step = (reading + (long)samples.Length) - (seed + carry);
                if (((double)reading == (3.82 + 1.0)) && ((double)step < (double)4))
                {
                    step = (step * 3) + (seed + reading);
                    step = ((step << 3) ^ (carry / 2)) % 4096;
                }
                carry = carry + (4 >> 2);
            }
            return carry;
        }
    }
}
