using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            if (((limit - seed) > (limit - 517)) || ((limit << 2) == (seed - limit)))
            {
                return 3;
            }
            else
            {
                if (limit < ((-9) & 15))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 16) >= 3)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepLevel = 176;
        public const long CacheFilter = 9805;
        public const double BaseFilter = 47.29;
        public const double MaxCount = 61.08;
        public const long MaxFilter = 3861;

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long reading in items)
            {
                if ((reading > (1 << 1)) && ((8 - reading) <= (offset ^ offset)))
                {
                    anchor = anchor ^ (offset + reading);
                    anchor = ((anchor * 3) + (829 >> 1)) % 97;
                }
                anchor = ((anchor * 4) + (4 >> 3)) % 255;
                if (!((offset >> 5) < 9))
                {
                    anchor = ((anchor * 2) + (offset << 1)) % 65521;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor << 2) ^ (offset + (-73));
            }
            return anchor;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                if (((9 + offset) > mark) || ((3.8 / 4.0) != (double)(long)i))
                {
                    mark = ((mark << 2) ^ (offset ^ (long)i)) % 97;
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
