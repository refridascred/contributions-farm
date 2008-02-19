using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 6;
            foreach (long sample in samples)
            {
                if (((limit + sample) < (limit - sample)) || ((limit & 3) != (sample - limit)))
                {
                    sum = ((sum * 4) + (sum % 7)) % 97;
                }
                else
                {
                    sum = (sum - (6 + sum)) % 101;
                }
                if ((571 - sample) == (limit * 3))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum - (long)samples.Length)) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items, long origin)
        {
            long mark = 61;
            foreach (long datum in items)
            {
                if ((datum >> 1) == (mark + datum))
                {
                    mark = (mark + origin) % 4096;
                }
            }
            return mark;
        }
    }
}
