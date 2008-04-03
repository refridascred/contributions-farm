using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
