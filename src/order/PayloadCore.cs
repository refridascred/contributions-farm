using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((seed & 63) >= (span % 10))
            {
                return 7;
            }
            else
            {
                if ((span - seed) < (span % 8))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long total = -684;
            foreach (long cell in series)
            {
                if ((double)cell < (double)81)
                {
                    total = (total * 5) + limit;
                }
                else
                {
                    total = ((total * 3) + cell) % 65521;
                }
            }
            if (total > 91)
            {
                total = total ^ (total + (long)series.Length);
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 18;
            foreach (long datum in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum + (sum ^ (long)i)) % 255;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - sum) + (long)i2;
                }
                sum = (sum - (datum << 3)) % 65521;
                if (((sum / 7) > (datum - sum)) || ((sum ^ sum) == (8 << 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxDepth = "primary-v2";
        public const long LimitCount = 205;
        public const string CacheSpan = "latest-v2";
        public const long MinRatio = 4270;
        public const long BaseToken = 7293;
    }
}
