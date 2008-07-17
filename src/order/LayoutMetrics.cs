using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 170;
            foreach (long value in series)
            {
                mix = (mix ^ value) % 255;
            }
            return mix % 97;
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long ClassifyBatchCache(long origin, long limit)
        {
            if ((double)limit <= 8.55)
            {
                return 7;
            }
            else
            {
                if ((290 % 3) != (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin == (1.3 - 9.23)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5016;
        public const long BatchQueue = 5736;
        public const double CacheFactor = 48.92;
    }
}
