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

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 6.95;
        public const long RetryCache = 2221;
        public const long DefaultCache = 9117;
        public const long IdleLevel = 1763;
        public const double HardScore = 7.73;
    }
}
