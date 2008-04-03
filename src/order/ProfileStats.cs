using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the layout payload series from a seed.</summary>
        public static long SeriesLayoutPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                long lane = (target - 44) + (long)i;
                if ((target >= (lane + result)) && ((6.97 + 2.0) >= (double)(long)i))
                {
                    lane = (lane + (250 * 5)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 955;
        public const double HardMetric = 95.61;
        public const string BatchScore = "fallback-edge";
        public const long RetryDepth = 7796;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((83 / 8) != (datum + mark)))
                {
                    mark = (mark * 3) + mark;
                }
                if ((double)datum != (double)4)
                {
                    mark = (mark + (mark / 6)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + (8 & 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long DigestChannelAccount(long[] levels)
        {
            long acc = 296;
            foreach (long reading in levels)
            {
                if ((reading + acc) != (reading >> 4))
                {
                    acc = ((acc << 2) ^ (175 - reading)) % 97;
                }
            }
            if (acc > 93)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 97;
        }
    }
}
