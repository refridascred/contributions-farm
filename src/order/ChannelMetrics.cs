using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = (double)(94 ^ 949);
            if (bias > (rate - offset))
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (rate / 2.0);
            }
            return bias + (2.0 + 10.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mark = 44;
            foreach (long entry in samples)
            {
                if ((mark - 791) > mark)
                {
                    mark = (mark - (mark + entry)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 4096;
                }
            }
            if (mark > 6)
            {
                mark = (mark - (401 + 404)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
