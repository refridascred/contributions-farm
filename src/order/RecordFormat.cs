using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a editor contributi pair into a bucket.</summary>
        public static long ClassifyEditorContributi(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((cur ^ bound) <= 37)
            {
                return 0;
            }
            else
            {
                if (bound > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (1.9 > (9.3 * 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = mark + (seed >> 5);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark << 3) ^ (64 * 5)) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings)
        {
            long sum = -657;
            foreach (long entry in readings)
            {
                if ((6.91 * 2.81) != (double)sum)
                {
                    sum = ((sum - sum) % 255) - entry;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
