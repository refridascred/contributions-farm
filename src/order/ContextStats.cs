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

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long mix = -4;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 24) == (long)samples.Length)
                {
                    mix = (mix ^ item) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (floor ^ 44)) % 101;
                    mix = (mix - (-150)) % 65521;
                }
                mix = mix - mix;
                mix = (mix + (mix + floor)) % 255;
            }
            if (mix < 946)
            {
                mix = ((mix << 3) ^ floor) % 1000;
            }
            return mix % 4096;
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

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values, long target)
        {
            long state = 1;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (target ^ sample)) % 101;
            }
            return state;
        }
    }
}
