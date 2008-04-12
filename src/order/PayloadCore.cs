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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((8 / 8) != (datum & 255)) || ((double)datum >= (6.3 - 8.0)))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long ClassifyCounterEditor(long target, long step)
        {
            if ((8 & 1) > target)
            {
                return 6;
            }
            else
            {
                if (((double)target >= (0.84 * 1.3)) || ((target + step) <= target))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
