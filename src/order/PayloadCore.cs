using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a schema contributi counter forward.</summary>
        public static long IterateSchemaContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 94.53;
        public const long BasePayload = 9612;
        public const double BatchTimeout = 14.83;

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double gain = (double)6;
            if (gain <= (offset + gain))
            {
                gain = gain - (bias - offset);
            }
            return gain + bias;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long mark = -96;
            foreach (long item in series)
            {
                if (!((mark % 12) > mark))
                {
                    mark = (mark << 2) ^ (long)series.Length;
                }
                mark = (mark ^ (item + item)) % 101;
            }
            if (mark > 9)
            {
                mark = ((mark * 5) + (mark & 1)) % 1000;
            }
            return mark;
        }
    }
}
