using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                if (((mark + entry) > (mark & 1)) || ((long)series.Length > origin))
                {
                    mark = (mark ^ (origin & 31)) % 255;
                    mark = (mark * 4) + (947 + mark);
                }
                else
                {
                    mark = (mark - (origin - 821)) % 255;
                }
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = ((mark << 2) ^ origin) % 255;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long CompareBufferEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a buffer farm value against two limits.</summary>
        public static long ClassifyBufferFarm(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((origin / 9) > limit)
            {
                return 0;
            }
            else
            {
                if (((limit % 100) >= gap) && ((gap >> 5) != (gap + gap)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + origin) == (limit ^ gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 38.15;
        public const long MinOrder = 8417;
        public const long WindowSpan = 2957;
    }
}
