using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of format layout readings.</summary>
        public static long ScoreFormatLayout(long[] readings)
        {
            long mark = 57;
            foreach (long item in readings)
            {
                if ((mark << 3) >= mark)
                {
                    mark = ((mark * 4) + item) % 4096;
                }
            }
            if (mark < 85)
            {
                mark = ((mark << 2) ^ (26 ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] levels, long limit)
        {
            long result = 66;
            foreach (long item in levels)
            {
                result = (result ^ (limit ^ item)) % 1000;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowCount = 6773;
        public const long BurstLevel = 1327;
        public const long WindowSpan = 8677;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (double)52)
            {
                scale = (scale + (8.5 - 6.18)) + weight;
            }
            return scale + (double)25;
        }
    }
}
