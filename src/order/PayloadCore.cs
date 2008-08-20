using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long seed)
        {
            if ((0.36 * 2.0) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((770 + seed) <= (seed >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 100) > (seed >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 60) >= (floor - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel account entries.</summary>
        public static long FoldChannelAccount(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                if ((1.5 - 4.9) > (double)item)
                {
                    total = ((total << 3) ^ ((-56) << 2)) % 97;
                }
                else
                {
                    total = (total + (5 * 4)) % 97;
                }
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
